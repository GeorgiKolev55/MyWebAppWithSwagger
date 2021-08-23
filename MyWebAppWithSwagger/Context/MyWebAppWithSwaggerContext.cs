using Microsoft.EntityFrameworkCore;
using MyWebAppWithSwagger.Models;

namespace MyWebAppWithSwagger.Context
{
    public class MyWebAppWithSwaggerContext :DbContext
    {
        public MyWebAppWithSwaggerContext(DbContextOptions<MyWebAppWithSwaggerContext> options) : base(options)
        {

        }


        public DbSet<Book> Books { get; set; }
    }
}
