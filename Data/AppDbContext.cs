using Microsoft.EntityFrameworkCore;

namespace DemoApp.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    // private string connectionString = "Host = localhost; Port = 5234;Database = NoUsers; Username = postgres; Password = qwerty";
    public DbSet<User> Users { get; set; }
    
}