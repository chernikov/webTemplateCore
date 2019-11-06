using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using webTemplate.Swagger.Output.Enums;
using webTemplate.Swagger.Swagger;

namespace webTemplate.Swagger.Output
{
    public class OutputServiceAction
    {
        private Regex RegexPathParameter = new Regex("{(.*)}");
        public string Path { get; set; }

        public List<PathChunk> PathChunks
        {
            get
            {
                var list = new List<PathChunk>();

                var pathParts = Path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var pathPart in pathParts)
                {
                    var match = RegexPathParameter.Match(pathPart);
                    if (match.Success)
                    {
                        var parameterName = match.Groups[0].Value;
                        list.Add(new PathChunk()
                        {
                            Name = parameterName,
                            IsParameter = true
                        });
                    }
                    else
                    {
                        list.Add(new PathChunk()
                        {
                            Name = pathPart,
                            IsParameter = false
                        });
                    }
                }

                return list;
            }
        }

        public MethodTypeEnum Method { get; set; }

        public string AngularMethod
        {
            get
            {
                return Method.ToString().ToLower();
            }
        }

        public string AngularInputParameters
        {
            get
            {
                return string.Join(",", Parameters.Select(p => $"{p.Name}: Type"));
            }
        }

        public List<OutputServiceActionParameter> Parameters { get; set; }

        public OutputClass RequestBody { get; set; }

        public List<DocumentResponse> Responses { get; set; }


        public static MethodTypeEnum ParseMethodType(string method)
        {
            switch (method.ToLower())
            {
                case "get":
                    return MethodTypeEnum.Get;
                case "post":
                    return MethodTypeEnum.Post;
                case "put":
                    return MethodTypeEnum.Put;
                case "delete":
                    return MethodTypeEnum.Delete;
                default:
                    return default;
            }
        }

        public static List<OutputServiceActionParameter> ParseParameters(List<DocumentParameter> parameters)
        {
            var list = new List<OutputServiceActionParameter>();

            if (parameters != null && parameters.Count > 0)
            {
                foreach (var parameter in parameters)
                {
                    list.Add(new OutputServiceActionParameter()
                    {
                        Name = parameter.Name,
                        Required = parameter.Required,

                    });
                }
            }
            return list;
        }

        public static OutputClass ParseRequestBody(DocumentRequestBody requestBody)
        {
            if (requestBody == null)
            {
                return null;
            }


        }
    }
}
