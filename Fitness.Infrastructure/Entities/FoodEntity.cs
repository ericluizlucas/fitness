using Fitness.Infrastructure.Interfaces;

namespace Fitness.Infrastructure.Entities
{
    public class Food : BaseEntity, IBaseEntity
    {
        public string? Name { get; set; } = null;

        public int CategoryId { get; set; }

        public FoodCategory Category { get; set; }
    }
}