using Microsoft.EntityFrameworkCore;
using Application.Models;

namespace Application.Data;

public class ApplicationDbContext : DbContext
{
    //Sets maps to a table created in the database 
    public DbSet<MyEntity> MyEntities { get; set; }

    public DbSet<Book> MyBooks { get; set; }
    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}