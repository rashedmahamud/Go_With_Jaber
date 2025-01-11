using DB_Project.EntityModel;
using Microsoft.EntityFrameworkCore;

namespace DB_Project
{

    
    public class MyDbContext: DbContext
    {

         public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

}
