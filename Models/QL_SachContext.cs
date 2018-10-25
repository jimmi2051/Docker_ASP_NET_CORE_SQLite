using Microsoft.EntityFrameworkCore;

namespace QL_Sach.Models
{
    public class QL_SachContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./QL_Sach.db");
        }
    }

}