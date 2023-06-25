namespace Fitness.Infrastructure.Entities
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; } = null;

        public ICollection<Food> Foods { get; set; }
    }
}