using AsuTask.Application.Dtos;
using AsuTask.Common;

namespace AsuTask.Application.Services
{
    public interface IBookService
    {
        Task<PagedList<BookDto>> GetBooksAsync(int page, int size);
    }
}
