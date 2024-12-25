namespace MyShop;
using MyShop.Models;
using Microsoft.EntityFrameworkCore;


public class MyShopDBContext : DbContext
{
    public MyShopDBContext()
    {
        
    }
    public MyShopDBContext(DbContextOptions<MyShopDBContext> options)
    :base(options)
    {
    }
    
    public DbSet<Clients> clients { get; set; }
    public DbSet<Producers> producers { get; set; }
    public DbSet<Goods> goods { get; set; }
    public DbSet<Orders> orders { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        // Goods -> Producer
        modelbuilder.Entity<Goods>()
            .HasOne(g => g.Producer)
            .WithMany(p => p.goods)
            .HasForeignKey(g => g.ProducersId);
        
        // Orders -> Clients
        modelbuilder.Entity<Orders>()
            .HasOne(o => o.client)
            .WithMany(c => c.orders)
            .HasForeignKey(o => o.ClientId);
        
        // Goods -> Orders
        modelbuilder.Entity<Goods>()
            .HasMany(g => g.Orders)
            .WithMany(o => o.goods);

        // Orders -> Clients
        
    }
}