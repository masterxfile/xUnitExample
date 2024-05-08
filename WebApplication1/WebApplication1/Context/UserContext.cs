using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class UserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "UserDb");
        }

        public DbSet<User> Users { get; set; }
    }
}