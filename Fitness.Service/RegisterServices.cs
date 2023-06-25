using Fitness.Infrastructure.RegisterORM;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
// using Fitness.Services.Interfaces;

namespace Fitness.Service
{
    public static class RegisterServices
    {
        public static void RegisterServiceIoC(this IServiceCollection services, IConfiguration configuration)
        {

            // services.RegisterRepositories(configuration);

            // services.AddScoped<IProductService, ProductService>();
        }
    }
}
