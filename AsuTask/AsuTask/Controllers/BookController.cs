using AsuTask.Application.Dtos;
using AsuTask.Application.Services;
using AsuTask.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AsuTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<PagedList<BookDto>>> GetBooks([FromQuery] PaginationFilter filter)
        {
            var result = await _bookService.GetBooksAsync(filter.PageNumber, filter.PageSize);

            return Ok(result);
        }
    }
}