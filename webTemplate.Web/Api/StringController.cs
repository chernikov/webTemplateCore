using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace webTemplate.Web.Api
{
    [Route("api/string")]
    public class StringController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok("Result");
        }


        [HttpGet("{param}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Get(string param)
        {
            return Ok(param);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] string param)
        {
            return Ok(param);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] string param)
        {
            return Ok(param);
        }

        [HttpDelete("{param}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Delete(string param)
        {
            return Ok(param);
        }
    }
}
