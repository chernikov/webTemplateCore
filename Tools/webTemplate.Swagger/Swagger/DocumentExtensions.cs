﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTemplate.Swagger.Swagger
{
    public static class DocumentExtensions
    {
        public static DocumentSchema ParseJTokenWithRef(this JToken source)
        {
            var @ref = (source as JObject)["$ref"]?.Value<string>();
            return @ref == null ?
                    JsonConvert.DeserializeObject<DocumentSchema>(source.ToString()) :
                    new DocumentSchema()
                    {
                        Ref = @ref
                    };
        }
    }
}
