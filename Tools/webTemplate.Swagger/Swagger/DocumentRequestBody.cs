using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTemplate.Swagger.Swagger
{
    public class DocumentRequestBody
    {
        public Dictionary<string, DocumentContent> Content { get; set; }
    }
}
