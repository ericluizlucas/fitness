using Fitness.Infrastructure.RegisterContext;
using Fitness.Service.Interfaces;
using Fitness.Service.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Fitness.Service
{
    public static class RegisterServices
    {
        public static void RegisterServiceIoC(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterRepositories(configuration);

            services.AddScoped<IFoodCategoryService, FoodCategoryService>();
            services.AddScoped<IFoodService, FoodService>();
        }
    }
}
