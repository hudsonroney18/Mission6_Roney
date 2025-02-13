using Microsoft.EntityFrameworkCore;
using Mission6_Roney.Models;

namespace Mission6_Roney.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; } // Represents the Movies table
    }
}