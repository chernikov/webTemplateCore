using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Api
{
    [Route("api/object-with-list")]
    public class ObjectWithListController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithListDto), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var obj = new ObjectWithListDto()
            {
                Id = 1,
                Items = new List<string>()
               {
                   "One", "Two", "Three"
               }
            };
            return Ok(obj);
        }


        [HttpGet("{param}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithListDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(string param)
        {
            var obj = new ObjectWithListDto()
            {
                Id = 1,
                Items = new List<string>() {
                   "One", "Two", "Three", param
                }
            };
            return Ok(obj);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithListDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] ObjectWithListDto param)
        {
            return Ok(param);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithListDto), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] ObjectWithListDto param)
        {
            return Ok(param);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithListDto), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            var obj = new ObjectWithListDto()
            {
                Id = id,
                Items = new List<string>() {
                   "One", "Two", "Three"
                }
            };
            return Ok(obj);
        }
    }
}
