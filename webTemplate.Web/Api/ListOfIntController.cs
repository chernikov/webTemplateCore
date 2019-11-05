using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;

namespace webTemplate.Web.Api
{
    [Route("api/list-of-int")]
    public class ListOfIntController : BaseController
    {
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<int>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var result = new List<int>() { 1, 2, 3, 4, 5 };
            return Ok(result);
        }


        [HttpGet("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<int>), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            var result = new List<int>() { 1, 2, 3, 4, 5 };
            return Ok(result);
        }


        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<int>), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromBody] List<int> list)
        {
            return Ok(list);
        }

        [HttpPut]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<int>), (int)HttpStatusCode.OK)]
        public IActionResult Put([FromBody]  List<int> list)
        {
            return Ok(list);
        }

        [HttpDelete("{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<int>), (int)HttpStatusCode.OK)]
        public IActionResult Delete(int id)
        {
            var result = new List<int>() { 1, 2, 3, 4, 5 };
            return Ok(result);
        }
    }
}
