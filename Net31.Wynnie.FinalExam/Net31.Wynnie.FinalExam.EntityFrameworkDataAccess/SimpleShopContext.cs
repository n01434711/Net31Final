using Microsoft.EntityFrameworkCore;
using Net31.Wynnie.FinalExam.Pocos;

namespace Net31.Wynnie.FinalExam.EntityFrameworkDataAccess
{
    public class SimpleShopContext : DbContext
    {

        public SimpleShopContext()
        {
        }

        public DbSet<CustomerPoco> Customers { get; set; }
        public DbSet<ProductPoco> Products { get; set; }
        public DbSet<OrderPoco> Orders { get; set; }
        public DbSet<OrderProductPoco> OrderProducts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionStringUtil.GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
