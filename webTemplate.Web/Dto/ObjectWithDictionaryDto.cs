using System.Collections.Generic;

namespace webTemplate.Web.Dto
{
    public class ObjectWithDictionaryDto
    {
        public int Id { get; set; }

        public Dictionary<int, string> Items { get; set; }
    }
}
