using AsuTask.Application.Dtos;
using AsuTask.Application.Mappers;
using AsuTask.Common;
using AsuTask.Repository.Enitites;
using AsuTask.Repository.Repositories;

namespace AsuTask.Application.Services
{
    internal class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper<BookDto, Book> _mapper;

        public BookService(IBookRepository bookRepository, IMapper<BookDto, Book> mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<PagedList<BookDto>> GetBooksAsync(int page, int size)
        {
            var books = await _bookRepository.GetBooksAsync(page, size);
            return new PagedList<BookDto>(books.Data.Select(_mapper.MapTo).ToList(), books.TotalCount, books.CurrentPage, books.PageSize);
        }
    }
}
