using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webTemplate.Web.Api
{
    [Route("api/value")]
    public class ValueController : Controller
    {
        public IActionResult Get()
        {
            var list = new string[] { "value1", "value2" };
            return Ok(list);
        }
    }
}
