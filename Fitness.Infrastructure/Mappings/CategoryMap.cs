using Fitness.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fitness.Infrastructure.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
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