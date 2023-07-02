using System.Data;
using Fitness.Infrastructure.Context;
using Fitness.Infrastructure.Entities;
using Fitness.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fitness.Infrastructure.Repositories
{
    public class FoodCategoryRepository : IFoodCategoryRepository
    {
        private readonly DataContext _context;

        public FoodCategoryRepository(DataContext context)
        {
            this._context = context;
        }

        public List<FoodCategory> GetAll()
        {
            return _context.Set<FoodCategory>().Include(x => x.Foods).OrderBy(x => x.Name).ToList();
        }

        public FoodCategory GetById(int id)
        {
            return _context.Set<FoodCategory>().Where(x => x.Id == id).Include(x => x.Foods).FirstOrDefault();
        }
        
        public void Insert(FoodCategory entity)
        {
            _context.Set<FoodCategory>().Add(entity);
            _context.SaveChanges();
        }
        
        public void Update(FoodCategory entity)
        {
            _context.Set<FoodCategory>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(FoodCategory entity)
        {
            _context.Set<FoodCategory>().Remove(entity);
            _context.SaveChanges();
        }
    }
}