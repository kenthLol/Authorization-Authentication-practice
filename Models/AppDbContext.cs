using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace practica4.Models;
public class AppDbContext : IdentityDbContext<IdentityUser> {
    public AppDbContext() { }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base (options) { }

    public DbSet<Artist> Artists { get; set;}
    public DbSet<Album> Albums { get; set;}
    public DbSet<Song> Songs { get; set;}
}