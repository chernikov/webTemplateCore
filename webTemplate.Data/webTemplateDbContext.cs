using Microsoft.EntityFrameworkCore;
using webTemplate.Domain;

namespace webTemplate.Data
{
    public class webTemplateDbContext : DbContext, IwebTemplateDbContext
    {
        public webTemplateDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(local);Initial Catalog=webTemplate;Trusted_Connection=True;MultipleActiveResultSets=true");
            //options.EnableSensitiveDataLogging(true);
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            var seeder = new Seeder();
            seeder.Seed(modelBuilder);
        }
    }

}
