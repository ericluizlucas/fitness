using System.Data;
using Fitness.Infrastructure.Context;
using Fitness.Infrastructure.Entities;
using Fitness.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Infrastructure.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly DataContext _context;

        public FoodRepository(DataContext context)
        {
            this._context = context;
        }

        public List<Food> GetAll()
        {
            return _context.Set<Food>().Include(x => x.Category).OrderBy(x => x.Name).ToList();
        }

        public Food GetById(int id)
        {
            return _context.Set<Food>().Where(x => x.Id == id).Include(x => x.Category).FirstOrDefault();
        }
        
        public void Insert(Food entity)
        {
            _context.Set<Food>().Add(entity);
            _context.SaveChanges();
        }
        
        public void Update(Food entity)
        {
            _context.Set<Food>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Food entity)
        {
            _context.Set<Food>().Remove(entity);
            _context.SaveChanges();
        }
    }
}