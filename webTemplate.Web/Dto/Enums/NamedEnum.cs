using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace webTemplate.Web.Dto.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NamedEnum
    {
        None,
        One,
        Two,
        Three
    }
}
