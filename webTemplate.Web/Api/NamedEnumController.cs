using Microsoft.AspNetCore.Mvc;
using System.Net;
using webTemplate.Web.Dto.Enums;

namespace webTemplate.Web.Api
{
    [Route("api/named-enum")]
    public class NamedEnumController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(NamedEnum), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {

            return Ok(NamedEnum.One);
        }


        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(NamedEnum), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var result = (NamedEnum)id;
            return Ok(result);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(NamedEnum), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] NamedEnum param)
        {
            return Ok(param);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(NamedEnum), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] NamedEnum param)
        {
            return Ok(param);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(NamedEnum), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            var result = (NamedEnum)id;
            return Ok(result);
        }
    }
}
