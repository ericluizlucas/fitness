using Fitness.Infrastructure.Interfaces;

namespace Fitness.Infrastructure.Entities
{
    public class FoodCategory : BaseEntity, IBaseEntity
    {
        public string? Name { get; set; } = null;

        public ICollection<Food> Foods { get; set; }
    }
}