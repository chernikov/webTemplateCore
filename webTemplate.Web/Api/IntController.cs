using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace webTemplate.Web.Api
{
    [Route("api/int")]
    public class IntController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok(1);
        }


        //[HttpGet("{id:int}")]
        //[Produces("application/json")]
        //[ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        //public IActionResult Get(int id)
        //{
        //    return Ok(id);
        //}

        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id, int id2)
        {
            return Ok(id);
        }


        [HttpPost]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] int i)
        {
            return Ok(i);
        }

        [HttpPut]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] int i)
        {
            return Ok(i);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(int), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            return Ok(id);
        }
    }
}
