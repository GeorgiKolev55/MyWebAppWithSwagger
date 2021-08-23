using MyWebAppWithSwagger.Models;
using System.Threading.Tasks;

namespace MyWebAppWithSwagger.Service
{
    public interface IBookService
    {
        public Task AddBook(Book book);


        public Task RemoveBook(int id);


        public Task UpdateBook(int id,Book book);


        public Task<Book[]> GetAllBooks();
    }
}
