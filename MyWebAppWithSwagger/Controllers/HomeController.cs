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
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly BookService _bookService;

        public HomeController(BookService bookService)
        {
            _bookService = bookService;
        }


        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult PostBook(Book book)
        {

            _bookService.AddBook(book);
            return Ok();

        }


        [HttpDelete]
        public IActionResult DeleteBoo(Book book)
        {

            _bookService.RemoveBook(book);

            return Ok();

        }


        [HttpPut]
        public IActionResult PutBook(Book book)
        {
            _bookService.UpdateBook(book);

            return Ok();
        }


        [HttpGet]
        public ActionResult<Book[]> GetAll()
        {
            return _bookService.GetAllBooks();
        }

    }
}
