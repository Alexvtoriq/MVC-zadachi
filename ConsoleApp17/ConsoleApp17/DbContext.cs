using Microsoft.EntityFrameworkCore;

public class BookstoreContext : DbContext
{
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=BookstoreDb;Integrated Security=True;"
        );
    }
}
