using MyWebAppWithSwagger.Context;
using MyWebAppWithSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppWithSwagger.Repository
{
    public class BookRepository :IBookRepository
    {
        private readonly MyWebAppWithSwaggerContext _appContext;
        public BookRepository(MyWebAppWithSwaggerContext appContext)
        {
            _appContext = appContext;
        }
        public void AddBook(Book book)
        {
            _appContext.Add(book);

            _appContext.SaveChanges();
        }

        public Book[] GetAllBooks()
        {
            return _appContext.Books.ToArray();
        }

        public void RemoveBook(Book book)
        {
            _appContext.Remove(book);

            _appContext.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _appContext.Update(book);

            _appContext.SaveChanges();
        }
    }
}
