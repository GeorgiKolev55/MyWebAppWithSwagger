using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebAppWithSwagger.Models;
using MyWebAppWithSwagger.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppWithSwagger.Controllers
{
    [ApiController]
    [Route("library/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

     

        [HttpPost]
        public async Task<IActionResult> PostBook(Book book)
        {
            await _bookService.AddBook(book);

            return Ok();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {

           await _bookService.RemoveBook(id);

            return Ok();

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutBook(int id,Book book)
        {
           await _bookService.UpdateBook(id,book);

            return Ok();
        }


        [HttpGet]
        public async Task<Book[]> GetBooks()
        {
            return await _bookService.GetAllBooks();
        }

    }
}
