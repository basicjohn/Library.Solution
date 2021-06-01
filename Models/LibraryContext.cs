using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Author> Author { get; set; }
    public DbSet<Book> Book { get; set; }
    public DbSet<AuthorBook> AuthorBook { get; set; }
    public DbSet<Patron> Patron { get; set; }
    public DbSet<Checkout> Checkout { get; set; }

    public LibraryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}