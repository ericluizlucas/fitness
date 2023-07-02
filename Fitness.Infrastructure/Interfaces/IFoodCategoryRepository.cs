using Fitness.Infrastructure.Entities;

namespace Fitness.Infrastructure.Interfaces
{
    public interface IFoodCategoryRepository
    {
        List<FoodCategory> GetAll();
        FoodCategory GetById(int id);
        void Insert(FoodCategory entity);
        void Update(FoodCategory entity);
        void Delete(FoodCategory entity);
    }
}