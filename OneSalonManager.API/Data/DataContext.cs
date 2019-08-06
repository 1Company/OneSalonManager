using Microsoft.EntityFrameworkCore;
using OneSalonManager.API.Models;

namespace OneSalonManager.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }

        public DbSet<Values> Values { get; set; }
        public DbSet<User> Users { get; set;}
        public DbSet<Photo> Photos { get; set; }
        
    }
}