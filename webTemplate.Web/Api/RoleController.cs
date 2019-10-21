using Microsoft.AspNetCore.Mvc;

namespace webTemplate.Web.Api
{
    [Route("/api/role")]
    public class RoleController : BaseController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
