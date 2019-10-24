using Microsoft.AspNetCore.Mvc;
using System.Net;
using webTemplate.Web.Dto;
using webTemplate.Web.Dto.Enums;

namespace webTemplate.Web.Api
{
    [Route("/api/metric")]
    public class MetricController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(MetricEnum), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var typedClass = new TypedClassDto()
            {
                Metric = MetricEnum.Number
            };
            return Ok(typedClass);
        }
    }
}
