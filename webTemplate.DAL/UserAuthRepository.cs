using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using webTemplate.Data;
using webTemplate.Domain;

namespace webTemplate.DAL
{
    public class UserAuthRepository : BaseRepository, IUserAuthRepository
    {
        public UserAuthRepository(Func<IWebTemplateDbContext> getDbContext) : base(getDbContext)
        {
        }

        public User Get(int id)
            => Execute(context => context.Users.FirstOrDefault(p => p.Id == id));

        public User GetByEmailAndPassword(string email, string password)
            => Execute(context => context.Users.FirstOrDefault(p => p.Email == email && p.Password == password));


        public Task<User> GetUserByEmailAsync(string userEmail)
            => Execute(context => context.Users.FirstOrDefaultAsync(p => p.Email == userEmail));
    }
}
