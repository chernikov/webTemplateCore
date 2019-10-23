using System.Security.Principal;

namespace webTemplate.Web.Services
{
    public class IdentityService : IIdentityService
    {
        private IPrincipal principal;

        public void Save(IPrincipal principal)
        {
            this.principal = principal;
        }

        public IPrincipal Restore()
        {
            return principal;
        }
    }
}
