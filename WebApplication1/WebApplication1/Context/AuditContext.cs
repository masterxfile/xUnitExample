using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class AuditContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "AuditDb");
        }
        
        public DbSet<Audit> Audits { get; set; }
    }
}
