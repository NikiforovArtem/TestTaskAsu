using AsuTask.Common;
using AsuTask.Repository.Contexts;
using AsuTask.Repository.Enitites;
using Microsoft.EntityFrameworkCore;

namespace AsuTask.Repository.Repositories
{
    public interface IBookRepository
    {
        Task<PagedList<Book>> GetBooksAsync(int page, int pageSize);
    }

    internal class BookRepository : IBookRepository
    {
        private readonly AsuTestContext _context;

        public BookRepository(AsuTestContext context)
        {
            _context = context;
        }

        public async Task<PagedList<Book>> GetBooksAsync(int page, int pageSize)
        {
            return await _context.Books.AsNoTracking().ToPagedListAsync(page, pageSize);
        }
    }
}
