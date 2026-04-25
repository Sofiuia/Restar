using Microsoft.EntityFrameworkCore;
using RestaurantManagementSystem.Models;

namespace RestaurantManagementSystem.Data;

public class AppDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<OrderDish> OrderDishes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=restaurant.db");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrderDish>()
            .HasKey(od => new { od.OrderId, od.DishId });

        modelBuilder.Entity<Customer>()
            .HasOne(c => c.Profile)
            .WithOne(p => p.Customer)
            .HasForeignKey<Profile>(p => p.CustomerId);
    }
}