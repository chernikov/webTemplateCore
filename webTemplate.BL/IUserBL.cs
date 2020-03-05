using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Domain;

namespace webTemplate.BL
{
    public interface IUserBL : IBaseBL
    {
        User GetById(int id);
    }
}
