using AutoMapper;
using Fitness.Common.Models;
using Fitness.Infrastructure.Entities;
using Fitness.Infrastructure.Interfaces;
using Fitness.Service.Interfaces;

namespace Fitness.Service.Services
{
    public class FoodCategoryService : IFoodCategoryService
    {
        private readonly IFoodCategoryRepository _repository;

        private readonly IMapper _mapper;

        public FoodCategoryService(IFoodCategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<FoodCategoryModel> GetAll()
        {
            try
            {
                var foodCategoryList = _repository.GetAll();
                List<FoodCategoryModel> resp = _mapper.Map<List<FoodCategoryModel>>(foodCategoryList);

                return resp;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public List<FoodCategoryModel> GetById(int id)
        {
            try
            {
                var foodCategoryList = _repository.GetById(id);
                List<FoodCategoryModel> resp = _mapper.Map<List<FoodCategoryModel>>(foodCategoryList);

                return resp;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool Insert(FoodCategory entity)
        {
            try
            {
                _repository.Insert(entity);
                return true;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool Update(FoodCategory entity)
        {
            try
            {
                _repository.Update(entity);
                return true;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _repository.GetById(id);
                _repository.Delete(entity);

                return true;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}