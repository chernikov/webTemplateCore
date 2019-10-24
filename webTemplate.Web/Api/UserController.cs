using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Api
{
    [Route("/api/user")]
    public class UserController : BaseController
    {
        [HttpGet]
        [Authorize(Roles = "admin")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<int>), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var list = new[] { 1, 2, 3 };
            return Ok(list);
        }


        [HttpPost]
        [Authorize(Roles = "admin")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(List<HardClassDto.SubClassDto>), (int)HttpStatusCode.OK)]
        public IActionResult Post([FromQuery] Guid guid, [FromBody] HardClassDto insert)
        {
            var list = new[] { 1, 2, 3 };
            return Ok(list);
        }
    }
}
