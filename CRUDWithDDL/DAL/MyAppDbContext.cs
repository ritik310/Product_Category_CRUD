using CRUDWithDDL.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDWithDDL.DAL
{
    public class MyAppDbContext : DbContext 
    {
        public MyAppDbContext(DbContextOptions options): base(options) 
        {
            
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get;   set; }
    }
}
