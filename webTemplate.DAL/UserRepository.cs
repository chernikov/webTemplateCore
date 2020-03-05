using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Data;
using webTemplate.Domain;

namespace webTemplate.DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(Func<IWebTemplateDbContext> getDbContext) : base(getDbContext)
        {
        }

        public User GetById(int id)
            => Query(context => context.Users.FirstOrDefault(p => p.Id == id));
    }
}
