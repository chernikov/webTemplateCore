using System;
using System.Collections.Generic;
using System.Linq;
using webTemplate.Data;
using webTemplate.Domain;

namespace webTemplate.DAL
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(Func<IWebTemplateDbContext> getDbContext) : base(getDbContext)
        {

        }


        public IList<Role> GetList() => Query((context) => context.Roles.ToList());
    }
}
