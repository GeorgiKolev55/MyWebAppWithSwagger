using MyWebAppWithSwagger.Models;
using MyWebAppWithSwagger.Repository;


namespace MyWebAppWithSwagger.Service
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public void AddBook(Book book)
        {

            _bookRepository.AddBook(book);

        }


        public void RemoveBook(Book book)
        {

            _bookRepository.RemoveBook(book);

        }


        public void UpdateBook(Book book)
        {

            _bookRepository.UpdateBook(book);

        }


        public Book[] GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}
