using AsuTask.Repository.Enitites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsuTask.Repository.EntityConfigurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(t => new { t.Id });
            builder.Property(t => t.Genre).HasColumnName("Genre");
            builder.Property(t => t.Name).HasColumnName("Name");
            builder.Property(t => t.AuthorName).HasColumnName("AuthorName");
            builder.HasData(
                new Book
                {
                    AuthorName = "A",
                    Genre = "B",
                    Id = Guid.NewGuid(),
                    Name = "Gg"
                },
                new Book
                {
                    AuthorName = "Ab",
                    Genre = "Bd",
                    Id = Guid.NewGuid(),
                    Name = "Gg1"
                },
            new Book
            {
                AuthorName = "Ag",
                Genre = "Bdd",
                Id = Guid.NewGuid(),
                Name = "Gg4"
            },
            new Book
            {
                AuthorName = "Ads",
                Genre = "Bxx",
                Id = Guid.NewGuid(),
                Name = "Gg77"
            },
                        new Book
                        {
                            AuthorName = "A1",
                            Genre = "Bd2",
                            Id = Guid.NewGuid(),
                            Name = "hhh2"
                        });
        }
    }
}
