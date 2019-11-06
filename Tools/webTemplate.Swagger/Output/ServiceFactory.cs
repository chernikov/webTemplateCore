using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Swagger.Output.Enums;
using webTemplate.Swagger.Swagger;

namespace webTemplate.Swagger.Output
{
    public class ServiceFactory
    {
        public List<OutputService> GetServices(Document document)
        {
            var services = new Dictionary<string, OutputService>();

            foreach (var path in document.Paths)
            {
                var servicePath = path.Key;
                foreach (var action in path.Value)
                {
                    var method = action.Key;
                    var actionValue = action.Value;
                    var tag = actionValue.Tags[0];
                    if (!services.ContainsKey(tag))
                    {
                        var newService = new OutputService()
                        {
                            Name = tag
                        };
                        services.Add(tag, newService);
                    }
                    var service = services[tag];
                    var outputAction = new OutputServiceAction()
                    {
                        Method = OutputServiceAction.ParseMethodType(method),
                        Path = servicePath,
                        RequestBody = OutputServiceAction.ParseRequestBody(actionValue.RequestBody),
                        Responses = actionValue.Responses.Values?.ToList(),
                        Parameters = OutputServiceAction.ParseParameters(actionValue.Parameters)
                    };
                    service.Actions.Add(outputAction);
                }
            }
            return services.Values.ToList();
        }

        internal List<ServiceFile> GenerateFiles(List<OutputService> services)
        {
            var list = new List<ServiceFile>();
            foreach (var service in services)
            {
                list.Add(new ServiceFile()
                {
                    FileName = $"{service.Name.GetKebabName()}.service.ts",
                    Content = GenerateContent(service)
                });
            }
            return list;
        }

        private string GenerateContent(OutputService service)
        {
            var sb = new StringBuilder();

            sb.AppendLine("import { Http, Headers, RequestOptions } from '@angular/http';");
            sb.AppendLine("import { Injectable } from '@angular/core';");
            sb.AppendLine("import { Observable } from 'rxjs';");
            sb.AppendLine("");
            sb.AppendLine("import { map } from \"rxjs/operators\";");
            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("@Injectable({ providedIn: \"root\" })");
            sb.AppendLine($"export class {service.Name}Service");
            sb.AppendLine("{");
            sb.AppendLine($"\tprivate apiUrl:string = '{service.Url}';");
            sb.AppendLine("");
            sb.AppendLine("\tprivate headers = new Headers({");
            sb.AppendLine("\t\t\"content-type\": \"application/json\"");
            sb.AppendLine("\t\t\"Accept\": \"application/json\"");
            sb.AppendLine("\t});");
            sb.AppendLine("");
            sb.AppendLine("constructor(private http: Http) {}");
            sb.AppendLine("");

            foreach (var action in service.Actions)
            {
                sb.AppendLine($"\t{action.AngularMethod}({action.AngularInputParameters}) : Observable<[Output]> {{");
                sb.AppendLine($"\t\treturn this.http.{action.AngularMethod}([collect url]this.apiUrl + \"/\" + id, [if post/put set parameter], this.options).pipe(map(res => res.json()));");
                sb.AppendLine("\t}");
                sb.AppendLine("");
            }
            sb.AppendLine("}");

            return sb.ToString();
        }
    }
}
