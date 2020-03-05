using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Domain;

namespace webTemplate.Web.Tests.InMemory
{
    public class UserRoleSeed : Seed<UserRole>
    {
        public override List<UserRole> Init()
        {
            return new List<UserRole>()
            {
                new UserRole() {Id = 1, RoleId = 1, UserId = 1},
                new UserRole() {Id = 2, RoleId = 2, UserId = 2}
            };
        }
    }
}
