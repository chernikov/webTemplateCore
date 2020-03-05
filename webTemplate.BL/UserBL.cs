using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.DAL;
using webTemplate.Domain;

namespace webTemplate.BL
{
    public class UserBL : IUserBL
    {
        private readonly IUserRepository userRepository;

        public UserBL(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }
    }
}
