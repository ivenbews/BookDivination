using Microsoft.EntityFrameworkCore;
using Parsing.Domain.Entities;

namespace Parsing.Infrastructure.Persistence
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> context):base(context){}
        public DbSet<Book> Books { get; set; }
        public DbSet<Page> Pages { get; set;}
        public DbSet<Line> Lines { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
