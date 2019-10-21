using AutoMapper;
using webTemplate.Domain;

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
