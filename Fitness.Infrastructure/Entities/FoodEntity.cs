namespace Fitness.Infrastructure.Entities
{
    public class Food : BaseEntity
    {
        public string? Name { get; set; } = null;

        public int CategoryId { get; set; }

        public Category Categoria { get; set; }
    }
}