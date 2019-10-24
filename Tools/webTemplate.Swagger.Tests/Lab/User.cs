using Newtonsoft.Json;

namespace webTemplate.Swagger.Tests.Lab
{
    [JsonConverter(typeof(UserConverter))]
    public class User
    {
        public string UserName { get; set; }
    }
}
