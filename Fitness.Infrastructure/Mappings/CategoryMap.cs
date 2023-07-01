using Fitness.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.Infrastructure.Mappings
{
    public class FoodCategoryMap : IEntityTypeConfiguration<FoodCategory>
    {
        public void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.ToTable("FoodCategory");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Uuid)
                .HasColumnType("varchar(60)")
                .IsRequired();
            
            builder.Property(p => p.Enable)
                .HasColumnType("tinyint")
                .IsRequired();
            
            builder.Property(p => p.CreatedAt)
                .HasColumnType("datetime")
                .IsRequired();
            
            builder.Property(p => p.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();
        }
    }
}