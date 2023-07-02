using Fitness.Common.Models;
using Fitness.Infrastructure.Entities;

namespace Fitness.Service.Interfaces
{
    public interface IFoodService
    {
        List<FoodModel> GetAll();
        List<FoodModel> GetById(int id);
        bool Insert(Food entity);
        bool Update(Food entity);
        bool Delete(int id);
    }
}