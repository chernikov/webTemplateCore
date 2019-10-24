using System.Collections.Generic;
using webTemplate.Web.Dto.Enums;

namespace webTemplate.Web.Dto
{
    public class HardClassDto
    {
        public class SubClassDto
        {
            public int Id { get; set; }

            public SimpleEnum Simple { get; set; }

            public SubClassDto Left { get; set; }

            public SubClassDto Right { get; set; }
        }

        public MetricEnum Metric { get; set; }

        public SimpleEnum Simple { get; set; }

        public SubClassDto SubCl { get; set; }

        public SubClassDto SubNaCl { get; set; }

        public Dictionary<string, string> Dict { get; set; }

        public Dictionary<int, string> IntDict { get; set; }

        public Dictionary<int, HardClassDto> DictClass { get; set; }

        public List<SubClassDto> List { get; set; }
    }
}
