using System;
using System.Collections.Generic;
using webTemplate.Swagger.Swagger;

namespace webTemplate.Swagger.Output
{
    public class ClassFactory
    {


        public List<BaseOutputClass> GetClasses(Document document)
        {
            var list = new List<BaseOutputClass>();
            var components = document.Components;
            foreach (var schema in components.Schemas)
            {
                var entity = CreateDefinition(schema.Key, schema.Value);
                list.Add(entity);
            }
            foreach (var entity in list)
            {
                if (entity is OutputClass)
                {
                    var @class = entity as OutputClass;
                    var schema = components.Schemas[@class.Name];
                    @class.SetProperties(this, list, schema);

                    @class.SetInnerClass(this, list, schema);
                }
            }

            return list;
        }

        private BaseOutputClass CreateDefinition(string name, DocumentSchema schema)
        {
            if (schema.Enum != null)
            {
                //create enum
                var @enum = new OutputEnum()
                {
                    Name = name
                };
                @enum.SetType(schema);
                @enum.Types = schema.Enum;
                return @enum;
            }
            else
            {
                //create class
                var @class = new OutputClass()
                {
                    Name = name
                };
                @class.SetType(schema);
                return @class;
            }
        }

        public List<ClassFile> GenerateFiles(List<BaseOutputClass> classes)
        {
            return new List<ClassFile>();
        }

        private BaseOutputClass CreateDefinition(DocumentSchema schema)
        {
            if (schema.Enum != null)
            {
                //create enum
                var @enum = new OutputEnum() { };
                @enum.SetType(schema);
                @enum.Types = schema.Enum;
                return @enum;
            }
            else
            {
                //create class
                var @class = new OutputClass() { };
                @class.SetType(schema);

                return @class;
            }
        }

        internal BaseOutputClass CreateDefinitionWithDeep(DocumentSchema schema, List<BaseOutputClass> list)
        {
            if (schema.Enum != null)
            {
                return CreateDefinition(schema);
            }
            else
            {
                //create class
                var @class = new OutputClass() { };
                @class.SetType(schema);
                @class.SetProperties(this, list, schema);
                @class.SetInnerClass(this, list, schema);
                return @class;
            }
        }
    }
}
