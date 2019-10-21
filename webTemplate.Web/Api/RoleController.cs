using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webTemplate.BL;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Api
{
    [Route("/api/role")]
    public class RoleController : BaseController
    {

        private readonly IRoleBL roleBL;
        private readonly IMapper mapper;

        public RoleController(IRoleBL roleBL, IMapper mapper)
        {
            this.roleBL = roleBL;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var roles = roleBL.GetList();
            var result = mapper.Map<List<RoleDto>>(roles);
            return Ok(result);
        }
    }
}
