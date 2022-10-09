using AsuTask.DAL.Enitites;
using AsuTask.DAL.EntityConfigurations;
using AsuTask.Repository.Enitites;
using AsuTask.Repository.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace AsuTask.Repository.Contexts
{
    internal class AsuTestContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public AsuTestContext(DbContextOptions<AsuTestContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
