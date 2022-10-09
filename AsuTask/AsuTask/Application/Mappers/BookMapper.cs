using AsuTask.Application.Dtos;
using AsuTask.Repository.Enitites;

namespace AsuTask.Application.Mappers
{
    internal sealed class BookMapper : IMapper<BookDto, Book>
    {
        public BookDto MapTo(Book source)
        {
            return new BookDto(source.AuthorName, source.Name, source.Genre, source.Id);
        }
    }
}
