using Microsoft.AspNetCore.Mvc;
using System.Net;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Api
{
    [Route("api/object-with-nested")]
    public class ObjectWithNestedController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithNestedDto), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var obj = new ObjectWithNestedDto()
            {
                Id = 1,
                Result = new SimpleObjectDto()
                {
                    Id = 1,
                    Name = "Result"
                }
            };
            return Ok(obj);
        }


        [HttpGet("{param}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithNestedDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(string param)
        {
            var obj = new ObjectWithNestedDto()
            {
                Id = 1,
                Result = new SimpleObjectDto()
                {
                    Id = 1,
                    Name = param
                }
            };
            return Ok(obj);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithNestedDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] ObjectWithNestedDto param)
        {
            return Ok(param);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithNestedDto), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] ObjectWithNestedDto param)
        {
            return Ok(param);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithNestedDto), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            var obj = new ObjectWithNestedDto()
            {
                Id = id,
                Result = new SimpleObjectDto()
                {
                    Id = id,
                    Name = "Result"
                }
            };
            return Ok(obj);
        }
    }
}
