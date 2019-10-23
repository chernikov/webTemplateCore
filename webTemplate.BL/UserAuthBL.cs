using webTemplate.DAL;
using webTemplate.Domain;

namespace webTemplate.BL
{
    public class UserAuthBL : IUserAuthBL
    {
        private readonly IUserAuthRepository userAuthRepository;

        public UserAuthBL(IUserAuthRepository userAuthRepository)
        {
            this.userAuthRepository = userAuthRepository;
        }

        public User GetUserById(int id)
        {
            return userAuthRepository.Get(id);
        }
    }
}
