using EClothing.Domain.SharedContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace EClothing.Infra
{
    public class EClothingContext: DbContext
    {
        public EClothingContext(DbContextOptions<EClothingContext> options) : base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<ProductSize>()
            .HasOne(ps => ps.Product)
            .WithMany(p => p.Sizes);

        }
        
    }
}