using System.Collections.Generic;

namespace webTemplate.Swagger.Swagger
{
    public class DocumentAction
    {
        public List<string> Tags { get; set; }

        public List<DocumentParameter> Parameters { get; set; }

        public Dictionary<string, DocumentResponse> Responses { get; set; }
    }
}
