namespace Fitness.Infrastructure.Entities
{
    public class FoodCategory : BaseEntity
    {
        public string? Name { get; set; } = null;

        public ICollection<Food> Foods { get; set; }
    }
}