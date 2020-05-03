using EClothing.Domain.SharedContext.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EClothing.Infra.SharedContext.Mapping
{
    public class ProductSizeMap : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
             builder.HasOne(ps => ps.Product)
            .WithMany(p => p.Sizes);
        }
    }
}