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

        public RoleBL(IRoleRepository courseRepository)
        {
            this.roleRepository = courseRepository;
        }

        public IList<Role> GetList()
        {
            return roleRepository.GetList();
        }
    }
}
