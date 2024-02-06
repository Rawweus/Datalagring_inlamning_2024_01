using Datalagring_inlamning_2024_01.Entities;
using Microsoft.EntityFrameworkCore;

namespace Datalagring_inlamning_2024_01.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public virtual DbSet<CategoryEntity> Categories { get; set; }
    public virtual DbSet<CustomerEntity> Customers { get; set; }
    public virtual DbSet<OrderEntity> Orders { get; set; }
    public virtual DbSet<OrderDetailEntity> OrderDetails { get; set; }
    public virtual DbSet<ProductEntity> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CategoryEntity>()
            .HasKey(c => c.CategoryId)
            .HasName("PK_Category");

        modelBuilder.Entity<CategoryEntity>()
            .Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        modelBuilder.Entity<CategoryEntity>()
            .HasMany(c => c.Products)
            .WithOne(p => p.Category)
            .HasForeignKey(p => p.CategoryId);
        
        modelBuilder.Entity<CustomerEntity>()
            .HasKey(c => c.CustomerId);

        modelBuilder.Entity<ProductEntity>()
            .HasKey(pe  => pe.ProductId);

        modelBuilder.Entity<ProductEntity>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId);

        modelBuilder.Entity<ProductEntity>()
            .Property(p => p.Price)
            .HasPrecision(18, 2);

        modelBuilder.Entity<OrderEntity>()
            .HasKey(oe => oe.OrderId);

        modelBuilder.Entity<OrderEntity>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Orders)
            .HasForeignKey(o => o.CustomerId);

        modelBuilder.Entity<OrderDetailEntity>()
            .HasKey(od => od.OrderDetailId);

        modelBuilder.Entity<OrderDetailEntity>()
            .HasOne(o => o.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderId);

        modelBuilder.Entity<OrderDetailEntity>()
            .HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductId);

        modelBuilder.Entity<OrderDetailEntity>()
            .Property(od => od.UnitPrice)
            .HasPrecision(18, 2);
    }

}
