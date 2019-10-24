using Newtonsoft.Json;
using System.Collections.Generic;

namespace webTemplate.Swagger.Swagger
{
    public class DocumentSchema
    {

        public string Type { get; set; }

        public bool Nullable { get; set; }

        public string Format { get; set; }

        [JsonProperty("$ref")]
        public string Ref { get; set; }

        //Apply on type = array 
        public DocumentSchema Items { get; set; }


        //Apply on type = object 
        public Dictionary<string, DocumentSchema> Properties { get; set; }


        public List<string> Required { get; set; }
    }
}
