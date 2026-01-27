using Microsoft.EntityFrameworkCore;

public class GroceryStoreContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=CodeFirst_GroceryStore;Integrated Security=True;"
        );
    }

    
}
