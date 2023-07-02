namespace Fitness.Common.Models
{
    public class FoodCategoryModel : BaseModel
    {
        private IList<FoodModel> _foods = new List<FoodModel>();

        public string? Name { get; set; } = null;

        public IEnumerable<FoodModel> Foods { get { return _foods; } }

        public void AddFood(FoodModel food)
        {
            if (food == null) throw new Exception("Can't add a null food model to the list");

            _foods.Add(food);
        }
    }
}