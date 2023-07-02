// using Fitness.Infrastructure.Interfaces;
// using Fitness.Infrastructure.Repositories;

using Fitness.Infrastructure.Context;
using Fitness.Infrastructure.Interfaces;
using Fitness.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fitness.Infrastructure.RegisterContext
{

    public static class RegisterContext
    {
        public static void RegisterRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 11)), o=> o.MigrationsAssembly("Fitness.WebApi")));

            services.AddScoped<IFoodCategoryRepository, FoodCategoryRepository>();
            services.AddScoped<IFoodRepository, FoodRepository>();

        }
    }
}