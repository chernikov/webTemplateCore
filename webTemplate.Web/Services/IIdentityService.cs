using System.Security.Principal;

namespace webTemplate.Web.Services
{
    public interface IIdentityService
    {
        void Save(IPrincipal principal);

        IPrincipal Restore();
    }
}
