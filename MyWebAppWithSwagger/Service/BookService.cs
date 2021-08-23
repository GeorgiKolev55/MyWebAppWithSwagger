using MyWebAppWithSwagger.Models;
using MyWebAppWithSwagger.Repository;
using System.Threading.Tasks;

namespace MyWebAppWithSwagger.Service
{
    public class BookService :IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public async Task AddBook(Book book)
        {

           await _bookRepository.AddBookAsync(book);

        }


        public async Task RemoveBook(int id)
        {
           await _bookRepository.RemoveBookAsync(id);
        }


        public async Task UpdateBook(int id,Book book)
        {
           await _bookRepository.UpdateBookAsync(id,book);
        }


        public async Task<Book[]> GetAllBooks()
        {
            return await _bookRepository.GetAllBooksAsync();
        }
    }
}
