using AutoMapper;
using Fitness.Common.Models;
using Fitness.Infrastructure.Entities;
// using Fitness.Common.Models;
// using Fitness.Infrastructure.Entities;

namespace Fitness.Service
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<FoodCategoryModel, FoodCategory>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<FoodCategory, FoodCategoryModel>();

            CreateMap<FoodModel, Food>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<Food, FoodModel>();
        }
    }
}
