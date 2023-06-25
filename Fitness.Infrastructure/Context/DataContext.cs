using Fitness.Infrastructure.Entities;
using Fitness.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
        }

        public  DbSet<Food> Foods { get; set; }

        public  DbSet<Category> Categories { get; set; }
    }
}