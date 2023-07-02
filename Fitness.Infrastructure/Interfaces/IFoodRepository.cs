using Fitness.Infrastructure.Entities;

namespace Fitness.Infrastructure.Interfaces
{
    public interface IFoodRepository
    {
        List<Food> GetAll();
        Food GetById(int id);
        void Insert(Food entity);
        void Update(Food entity);
        void Delete(Food entity);
    }
}