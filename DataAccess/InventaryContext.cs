using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        public DbSet<InOutEntity> InOuts { get; set; }

        public DbSet<StorageEntity> Storages { get; set; }

        public DbSet<WarehouseEntity> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=GM-DESARROLLO2\\MSSQL; DataBase=InventoryDb; user=sa; password=listosoft01@;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName="Aseo Hogar"},
                new CategoryEntity { CategoryId = "ASP", CategoryName ="Aseo Personal"},
                new CategoryEntity { CategoryId = "HGR", CategoryName ="Hogar"},
                new CategoryEntity { CategoryId = "PRF", CategoryName ="Perfumeería"},
                new CategoryEntity { CategoryId = "SLD", CategoryName ="Salud"},
                new CategoryEntity { CategoryId = "VDJ", CategoryName ="Video Juegos"}
            );


            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Central", WarehouseAdress = "Alborada"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Sur", WarehouseAdress = "Esteros"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Oeste", WarehouseAdress = "Mapasingue"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Este", WarehouseAdress = "Centenario"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Norte", WarehouseAdress = "La Garzota"}
            );
        }
    }
}
