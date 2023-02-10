using Microsoft.EntityFrameworkCore;
using MinimalApiProject.Models;

namespace MinimalApiProject.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Command> Commands = null!;
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

    }
}