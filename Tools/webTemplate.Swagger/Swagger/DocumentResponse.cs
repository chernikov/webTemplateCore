using System.Collections.Generic;

namespace webTemplate.Swagger.Swagger
{
    public class DocumentResponse
    {
        public string Description { get; set; }

        public Dictionary<string, DocumentSchema> Content { get; set; }
    }
}
