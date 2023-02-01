using Microsoft.EntityFrameworkCore;

using itprogershop.Data.Models;

namespace itprogershop.Data;

public class AppDBContent : DbContext {
    public AppDBContent(DbContextOptions<AppDBContent> option) : base(option) {
        
    }
    
    public DbSet<Car> Car { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<ShopCartItem> ShopCartItem { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<OrderDetail> OrderDetail { get; set; }
}