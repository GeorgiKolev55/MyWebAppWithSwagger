using Microsoft.EntityFrameworkCore;
using MyWebAppWithSwagger.Context;
using MyWebAppWithSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppWithSwagger.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly MyWebAppWithSwaggerContext _appContext;
        public BookRepository(MyWebAppWithSwaggerContext appContext)
        {
            _appContext = appContext;
        }
        public async Task AddBookAsync(Book book)
        {
            var bookToAdd = new Book() { Name = book.Name , Price = book.Price };


            await _appContext.AddAsync(bookToAdd);

            await _appContext.SaveChangesAsync();
        }

        public async Task<Book[]> GetAllBooksAsync()
        {
            return await _appContext.Books.ToArrayAsync();
        }

        public async Task RemoveBookAsync(int id)
        {
            var bookToRemove = await _appContext.Books.FirstOrDefaultAsync(b => b.BookId == id);
            
            if (bookToRemove != null)
            {
                _appContext.Remove(bookToRemove);
            }

            await _appContext.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(int id, Book book)
        {
            var bookForUpdate = await _appContext.Books.FirstOrDefaultAsync(b => b.BookId == id);

            if (bookForUpdate != null)
            {
                bookForUpdate.Name = book.Name;
                bookForUpdate.Price = book.Price;
     
            }

            await _appContext.SaveChangesAsync();

        }
    }
}
