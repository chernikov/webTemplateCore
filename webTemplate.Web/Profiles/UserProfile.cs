using AutoMapper;
using System.Linq;
using webTemplate.Domain;
using webTemplate.Web.Dto;

namespace webTemplate.Web.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(p => p.Roles, opt => opt.MapFrom(r => r.UserRoles.Select(ur => ur.Role.Code)));
        }
    }
}
