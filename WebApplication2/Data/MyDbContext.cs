using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("SqlServerConnection")
        {

        }



        // Define your entities here
        public DbSet<Product> Products { get; set; }
    }
}