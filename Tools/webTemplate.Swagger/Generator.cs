using Newtonsoft.Json;
using System.Collections.Generic;
using webTemplate.Swagger.Output;
using webTemplate.Swagger.Swagger;

namespace webTemplate.Swagger
{
    public class Generator
    {
        private readonly Document swaggerDoc;

        public List<BaseFile> Files { get; set; } = new List<BaseFile>();


        public List<BaseOutputClass> Classes { get; set; } = new List<BaseOutputClass>();


        public Generator(string source)
        {
            swaggerDoc = JsonConvert.DeserializeObject<Document>(source);
        }

        public void Parse()
        {
            ParseClasses();
            ParseServices();
        }

        private void ParseClasses()
        {
            var factory = new ClassFactory();

            Classes = factory.GetClasses(swaggerDoc.Components);
        }

        private void ParseServices()
        {
        }
    }
}
