using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace webTemplate.Web.Api
{
    [Route("api/float")]
    public class FloatController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(float), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok(1f);
        }


        [HttpGet("{id:float}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(float), (int)HttpStatusCode.OK)]
        public IActionResult Get(float id)
        {
            return Ok(id);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(float), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] float i)
        {
            return Ok(i);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(float), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] float i)
        {
            return Ok(i);
        }

        [HttpDelete("{id:float}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(float), (int)HttpStatusCode.OK)]
        public IActionResult Delete(float id)
        {
            return Ok(id);
        }
    }
}
