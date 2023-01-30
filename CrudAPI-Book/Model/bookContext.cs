using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace CrudAPI_Book.Model
{
    public class bookContext : DbContext
    {
        public bookContext(DbContextOptions<bookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }
    }
}
