using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Data;
using webTemplate.Domain;

namespace webTemplate.DAL
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(webTemplateDbContext context) : base(context)
        {

        }

        public IList<Role> GetList()
        {
            return context.Roles.ToList();
        }
    }
}
