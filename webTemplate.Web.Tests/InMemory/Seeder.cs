using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webTemplate.Data;
using webTemplate.Domain;

namespace webTemplate.Web.Tests.InMemory
{
    public static class Seeder
    {
        public static void Seed(DbContext dbContext)
        {
            new RoleSeed().SeedInto(dbContext);
            new UserSeed().SeedInto(dbContext);
            new UserRoleSeed().SeedInto(dbContext);
        }
    }
}
