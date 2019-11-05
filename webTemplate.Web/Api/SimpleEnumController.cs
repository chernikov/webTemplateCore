using Microsoft.AspNetCore.Mvc;
using System.Net;
using webTemplate.Web.Dto.Enums;

namespace webTemplate.Web.Api
{
    [Route("api/simple-enum")]
    public class SimpleEnumController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleEnum), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {

            return Ok(SimpleEnum.One);
        }


        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleEnum), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var result = (SimpleEnum)id;
            return Ok(result);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleEnum), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] SimpleEnum param)
        {
            return Ok(param);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleEnum), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] SimpleEnum param)
        {
            return Ok(param);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleEnum), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            var result = (SimpleEnum)id;
            return Ok(result);
        }
    }
}
