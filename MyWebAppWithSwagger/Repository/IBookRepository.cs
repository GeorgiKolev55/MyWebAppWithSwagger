using MyWebAppWithSwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAppWithSwagger.Repository
{
    public interface IBookRepository
    {
        public Task AddBookAsync(Book book);


        public  Task RemoveBookAsync(int id);


        public Task UpdateBookAsync(int id,Book book);


        public Task<Book[]> GetAllBooksAsync();
    }
}
