using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace webTemplate.Web.Api
{
    [Route("/api/user")]
    public class UserController : BaseController
    {
        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Get()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); // will give the user's userId
            var userName = User.FindFirstValue(ClaimTypes.Name); // will give the user's userName
            var userEmail = User.FindFirstValue(ClaimTypes.Email); // will give the user's Email

            var list = new[] { 1, 2, 3 };
            return Ok(list);
        }

    }
}
