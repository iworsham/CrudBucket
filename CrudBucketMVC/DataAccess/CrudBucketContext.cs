using CrudBucketMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudBucketMVC.DataAccess
{
    public class CrudBucketContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public CrudBucketContext(DbContextOptions<CrudBucketContext> options) : base(options)
        {
            
        }
    }
}
