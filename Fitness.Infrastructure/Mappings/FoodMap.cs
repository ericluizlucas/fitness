using Fitness.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.Infrastructure.Mappings
{
    public class FoodMap : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.ToTable("Food");
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Uuid)
                .HasColumnType("varchar(60)")
                .IsRequired();
            
            builder.Property(f => f.Enable)
                .HasColumnType("tinyint")
                .IsRequired();
            
            builder.Property(f => f.CreatedAt)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(f => f.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.HasOne(f => f.Category)
                .WithMany(c => c.Foods)
                .HasForeignKey(c => c.Id)
                .HasPrincipalKey(f => f.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}