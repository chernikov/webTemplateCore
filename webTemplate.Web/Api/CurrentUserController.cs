using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using webTemplate.BL;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Api
{
    [Route("api/current-user")]
    public class CurrentUserController : BaseUserController
    {
        private readonly IMapper mapper;

        public CurrentUserController(IUserBL userBL, IMapper mapper) : base(userBL)
        {
            this.mapper = mapper;
        }

        [Authorize]
        [Produces("application/json")]
        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        public IActionResult Get()
        {
            var headers = this.Request.Headers;
            var result = mapper.Map<UserDto>(CurrentUser);
            return Ok(result);
        }
    }
}
