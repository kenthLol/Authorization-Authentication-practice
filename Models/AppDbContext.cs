using Microsoft.EntityFrameworkCore;

namespace practica4.Models;
public class AppDbContext : DbContext {
    public AppDbContext() { }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

    public DbSet<Artist> Artists { get; set;}
    public DbSet<Album> Albums { get; set;}
    public DbSet<Song> Songs { get; set;}
}