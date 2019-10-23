using Microsoft.AspNetCore.Mvc;
using webTemplate.Web.Dto;
using webTemplate.Web.Services;

namespace webTemplate.Web.Api
{
    [Route("api/auth")]
    public class AuthController : BaseController
    {
        private readonly IIdentityService userService;

        public AuthController(IIdentityService userService)
        {
            this.userService = userService;
        }



        [HttpPost]
        public IActionResult Post([FromBody]LoginDto userParam)
        {
            var token = userService.Authenticate(userParam.Email, userParam.Password);

            if (token == null)
            {
                return BadRequest(new { message = "Username or password is incorrect" });
            }

            return Ok(new { token });
        }
    }

}
