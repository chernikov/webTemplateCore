using Microsoft.AspNetCore.Mvc;
using System.Net;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Api
{
    [Route("api/simple-object")]
    public class SimpleObjectController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleObjectDto), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            return Ok(new SimpleObjectDto());
        }


        [HttpGet("{param}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleObjectDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(string param)
        {
            var obj = new SimpleObjectDto()
            {
                Name = param
            };
            return Ok(obj);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleObjectDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] SimpleObjectDto param)
        {
            return Ok(param);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleObjectDto), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] SimpleObjectDto param)
        {
            return Ok(param);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(SimpleObjectDto), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            var obj = new SimpleObjectDto()
            {
                Id = id
            };
            return Ok(obj);
        }
    }
}
