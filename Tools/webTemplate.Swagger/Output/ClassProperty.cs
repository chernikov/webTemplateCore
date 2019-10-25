using System.Diagnostics;

namespace webTemplate.Swagger.Output
{
    [DebuggerDisplay("Property: {Name} ({Class.FullName})")]
    public class ClassProperty
    {
        public bool IsNullable { get; set; }

        public string Name { get; set; }

        public BaseOutputClass Class { get; set; }
    }
}
