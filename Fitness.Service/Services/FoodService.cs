using AutoMapper;
using Fitness.Common.Models;
using Fitness.Infrastructure.Entities;
using Fitness.Infrastructure.Interfaces;
using Fitness.Service.Interfaces;

namespace Fitness.Service.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _repository;

        private readonly IMapper _mapper;

        public FoodService(IFoodRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<FoodModel> GetAll()
        {
            try
            {
                var foodList = _repository.GetAll();
                List<FoodModel> resp = _mapper.Map<List<FoodModel>>(foodList);

                return resp;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public List<FoodModel> GetById(int id)
        {
            try
            {
                var foodList = _repository.GetById(id);
                List<FoodModel> resp = _mapper.Map<List<FoodModel>>(foodList);

                return resp;
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool Insert(Food entity)
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

        public bool Update(Food entity)
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