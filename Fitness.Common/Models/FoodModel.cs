namespace Fitness.Common.Models
{
    public class FoodModel : BaseModel
    {
        public string? Name { get; set; } = null;

        public int CategoryId { get; set; }

        public FoodCategoryModel? Category { get; set; }

    }
}