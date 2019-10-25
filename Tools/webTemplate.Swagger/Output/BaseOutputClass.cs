using webTemplate.Swagger.Swagger;

namespace webTemplate.Swagger.Output
{
    public abstract class BaseOutputClass
    {
        public abstract string FullName { get; }

        public string Name { get; set; }

        public bool IsDictionary { get; set; }

        public string ReferenceName
        {
            get
            {
                return $"#/components/schemas/{Name}";
            }
        }

        public ClassTypeEnum Type { get; set; }

        public BaseOutputClass InnerClass { get; set; }

        public void SetType(DocumentSchema schema)
        {
            //string type, string format
            var type = schema.Type;
            var format = schema.Format;
            switch (type, format)
            {
                case var t when t.type == "array":
                    Type = ClassTypeEnum.Array;
                    break;
                case var t when t.type == "object":
                    Type = ClassTypeEnum.Object;
                    if (schema.AdditionalProperties != null)
                    {
                        IsDictionary = true;
                    }
                    break;
                case var t when t.type == "integer" && t.format == "int32":
                    Type = ClassTypeEnum.Integer;
                    break;
                case var t when t.type == "integer" && t.format == "int64":
                    Type = ClassTypeEnum.Long;
                    break;
                case var t when t.type == "string" && t.format == "date-time":
                    Type = ClassTypeEnum.DateTime;
                    break;
                case var t when t.type == "string" && t.format == "byte":
                    Type = ClassTypeEnum.Byte;
                    break;
                case var t when t.type == "string":
                    Type = ClassTypeEnum.String;
                    break;
                case var t when t.type == "number" && t.format == "double":
                    Type = ClassTypeEnum.Double;
                    break;
                case var t when t.type == "number" && t.format == "float":
                    Type = ClassTypeEnum.Float;
                    break;
            }

        }
    }
}
