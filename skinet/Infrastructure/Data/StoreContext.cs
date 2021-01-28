using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext //abstracting our db
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        public DbSet<Product> Products {get; set;}
        public DbSet<ProductBrand> ProductBrands {get; set;}
        public DbSet<ProductType> ProductTypes { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            //this method is responsible to Create Migration
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}