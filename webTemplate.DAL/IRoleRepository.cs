using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Domain;

namespace webTemplate.DAL
{
    public interface IRoleRepository : IBaseRepository
    {
        IList<Role> GetList();
    }
}
