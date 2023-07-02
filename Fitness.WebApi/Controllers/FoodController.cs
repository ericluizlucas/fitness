using Fitness.Infrastructure.Entities;
using Fitness.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fitness.WebAPI.Controllers
{
    [Route("[controller]")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodCategoryService _categoryService;

        private readonly IFoodService _foodService;
        
        public FoodController(IFoodCategoryService categoryService, IFoodService foodService)
        {
            _categoryService = categoryService;
            _foodService = foodService;
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var resp = _categoryService.GetAll();
            return new JsonResult(resp);
        }

        [HttpPost("category")]
        public JsonResult InsertFoodCategory([FromBody] FoodCategory entity)
        {
            var resp = _categoryService.Insert(entity);
            return new JsonResult(resp);
        }

        [HttpPost]
        public JsonResult InsertFood([FromBody] Food entity)
        {
            var resp = _foodService.Insert(entity);
            return new JsonResult(resp);
        }

    }
}
