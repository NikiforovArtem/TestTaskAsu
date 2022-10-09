using AsuTask.DAL.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsuTask.DAL.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(t => new { t.Id });
            builder.Property(t => t.Login).HasColumnName("Login");
            builder.Property(t => t.Password).HasColumnName("Password");
            builder.HasData(
                new User
                {
                    Login = "test@gmail.com",
                    Id = Guid.NewGuid(),
                    Password = "111111"
                });
        }
    }
}
