namespace AsuTask.Application.Dtos
{
    public class BookDto
    {
        public BookDto(string authorName, string name, string genre, Guid id)
        {
            AuthorName = authorName;
            Name = name;
            Genre = genre;
            Id = id;
        }

        public Guid Id { get; }

        public string Genre { get; }

        public string Name { get; }

        public string AuthorName { get; }
    }
}
