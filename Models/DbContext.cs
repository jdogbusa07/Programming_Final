using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RentBook>().HasKey(s => new {s.RentID, s.BookID});
    }    

    public DbSet<Rent> Rents {get; set;}
    public DbSet<Book> Books {get; set;}
    public DbSet<RentBook> RentBooks {get; set;}
}