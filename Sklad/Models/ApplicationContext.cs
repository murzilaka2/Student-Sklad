using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklad.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Storage> Storages { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Sheet> Sheets { get; set; } = null!;
        public ApplicationContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=skladStorage.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Storage>().HasData(
                new Storage() { Id = 1, Address = "Kiev, street 17/55", Name = "TechnoSklad" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, StorageId = 1, Name = "Mac Book 13", Price = 13000, Count = 7, Description = "Laptop from Mac", Date = DateTime.Now, Type = "Laptop" },
                new Product() { Id = 2, StorageId = 1, Name = "Iphone 12", Price = 17000, Count = 13, Description = "Iphone from Mac", Date = DateTime.Now.AddMonths(-3), Type = "Phone" },
                new Product() { Id = 3, StorageId = 1, Name = "Ipad Pro 2", Price = 13000, Count = 32, Description = "Ipad from Mac", Date = DateTime.Now.AddDays(-40), Type = "Tablet" }
                );
            modelBuilder.Entity<Sheet>().HasData(
                 new Sheet() { Id = 1, ActionType = Action.Addition, ProductName = "Mac Book 13", StorageName = "TechnoSklad" },
                 new Sheet() { Id = 2, ActionType = Action.Addition, ProductName = "Iphone 12", StorageName = "TechnoSklad" },
                 new Sheet() { Id = 3, ActionType = Action.Addition, ProductName = "Ipad Pro 2", StorageName = "TechnoSklad" }
                );
        }
    }
}
