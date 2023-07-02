using Fitness.Common.Models;
using Fitness.Infrastructure.Entities;

namespace Fitness.Service.Interfaces
{
    public interface IFoodCategoryService
    {
        List<FoodCategoryModel> GetAll();
        List<FoodCategoryModel> GetById(int id);
        bool Insert(FoodCategory entity);
        bool Update(FoodCategory entity);
        bool Delete(int id);
    }
}