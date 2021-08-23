using MyWebAppWithSwagger.Models;

namespace MyWebAppWithSwagger.Service
{
    public interface IBookService
    {
        public void AddBook(Book book);


        public void RemoveBook(Book book);


        public void UpdateBook(Book book);


        public Book[] GetAllBooks();
    }
}
