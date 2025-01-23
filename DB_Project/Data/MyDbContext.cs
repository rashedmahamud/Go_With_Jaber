using DB_Project.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace DB_Project
{

    
    public class MyDbContext: DbContext
    {

         public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<jaber> jabers { get; set; }
        public DbSet<frist> frists { get; set; } 
      
    }

}
