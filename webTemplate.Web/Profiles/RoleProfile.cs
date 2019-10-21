using AutoMapper;
using webTemplate.Domain;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>();
        }
    }
}
