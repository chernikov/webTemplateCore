using System.Collections.Generic;

namespace webTemplate.Swagger.Swagger
{
    public class Document
    {
        public string OpenApi { get; set; }

        public DocumentInfo Info { get; set; }

        public Dictionary<string, DocumentPath> Paths { get; set; }

        public DocumentComponent Components { get; set; }
    }
}
