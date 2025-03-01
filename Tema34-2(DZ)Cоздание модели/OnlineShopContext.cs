using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema34_2_DZ_Cоздание_модели.Entities;

public class OnlineShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Order> Orders { get; set; }

    public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
    {
        try
        {
            // Проверяем, существует ли база данных, и удаляем её
            if (Database.CanConnect())
            {
                Database.EnsureDeleted();
            }
            // Создаем базу данных
            Database.EnsureCreated();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при работе с базой данных: {ex.Message}");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Настройка связи между Product и Category
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany()
            .HasForeignKey(p => p.CategoryId);

        // Настройка связи между Order и User
        modelBuilder.Entity<Order>()
            .HasOne(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserId);

        // Настройка связи между Order и Product (многие ко многим)
        modelBuilder.Entity<Order>()
            .HasMany(o => o.Products)
            .WithMany()
            .UsingEntity(j => j.ToTable("OrderProducts"));
    }
}