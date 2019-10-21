using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Data;

namespace webTemplate.DAL
{
    public class BaseRepository
    {
        protected readonly webTemplateDbContext context;

        public BaseRepository(webTemplateDbContext context)
        {
            this.context = context;
        }
    }
}
