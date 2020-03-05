using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.DAL;
using webTemplate.Domain;

namespace webTemplate.BL
{
    public class RoleBL : IRoleBL
    {
        private readonly IRoleRepository roleRepository;

        public RoleBL(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public IList<Role> GetList()
        {
            return roleRepository.GetList();
        }
    }
}
