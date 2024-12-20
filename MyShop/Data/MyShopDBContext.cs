using Microsoft.EntityFrameworkCore;
using MyShop.Models;
using System.Reflection.Emit;
namespace MyShop.Data
{
    public class MyShopDBContext : DbContext
    {
        public DbSet<Clients> clients { get; set; }
        public DbSet<Producers> producers { get; set; }
        public DbSet<Goods> goods { get; set; }
        public DbSet<Orders> orders { get; set; }

        public MyShopDBContext(DbContextOptions<MyShopDBContext> options)
          : base(options)
        {
        }

        public MyShopDBContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Producer-Goods
            modelBuilder.Entity<Goods>()
                .HasOne(g => g.Producer)
                .WithMany(p => p.goods)
                .HasForeignKey(g => g.ProdusersId);

            // Client-Orders
            modelBuilder.Entity<Orders>()
                .HasOne(o => o.client)
                .WithMany(c => c.orders)
                .HasForeignKey(o => o.ClientId);

            // Goods-Orders
            modelBuilder.Entity<Goods>()
                .HasMany(g => g.Orders)
                .WithMany(o => o.goods);

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
