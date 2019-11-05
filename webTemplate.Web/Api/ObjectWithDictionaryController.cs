using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Api
{
    [Route("api/object-with-dictionary")]
    public class ObjectWithDictionaryController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithDictionaryDto), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var obj = new ObjectWithDictionaryDto()
            {
                Id = 1,
                Items = new Dictionary<int, string>()
                {
                    [1] = "One",
                    [2] = "Two",
                    [3] = "Three"
                }
            };
            return Ok(obj);
        }


        [HttpGet("{param}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithDictionaryDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(string param)
        {
            var obj = new ObjectWithDictionaryDto()
            {
                Id = 1,
                Items = new Dictionary<int, string>()
                {
                    [1] = "One",
                    [2] = "Two",
                    [3] = "Three"
                }
            };
            return Ok(obj);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithDictionaryDto), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] ObjectWithDictionaryDto param)
        {
            return Ok(param);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithDictionaryDto), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody] ObjectWithDictionaryDto param)
        {
            return Ok(param);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ObjectWithDictionaryDto), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            var obj = new ObjectWithDictionaryDto()
            {
                Id = id,
                Items = new Dictionary<int, string>()
                {
                    [1] = "One",
                    [2] = "Two",
                    [3] = "Three"
                }
            };
            return Ok(obj);
        }
    }
}
