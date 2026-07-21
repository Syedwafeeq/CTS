using Microsoft.EntityFrameworkCore;
using WEEK_4_Entity_Framework_Core.Models;

namespace WEEK_4_Entity_Framework_Core.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=localhost\SQLEXPRESS;
                      Database=StudentDB;
                      Integrated Security=True;
                      TrustServerCertificate=True;
                      Encrypt=False;");
            }
        }
    }
}