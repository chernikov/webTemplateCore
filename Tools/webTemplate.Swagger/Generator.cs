using Newtonsoft.Json;
using webTemplate.Swagger.Swagger;

namespace webTemplate.Swagger
{
    public class Generator
    {
        private readonly Document swaggerDoc;

        public Generator(string source)
        {
            swaggerDoc = JsonConvert.DeserializeObject<Document>(source);
        }




        public void Parse()
        {
            ParseClasses();
            ParseEnums();
            ParseServices();
        }

        public void ParseClasses()
        {

        }

        public void ParseEnums()
        {

        }

        public void ParseServices()
        {
        }

    }
}
