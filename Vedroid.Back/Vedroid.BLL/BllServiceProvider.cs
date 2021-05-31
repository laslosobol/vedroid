using Microsoft.Extensions.DependencyInjection;
using Vedroid.BLL.Interfaces;
using Vedroid.BLL.Services;

namespace Vedroid.BLL
{
    public static class BllServiceProvider
    {
        public static IServiceCollection RegisterBllServices(this IServiceCollection services)
        {
            services.AddTransient<IDrinkService, DrinkService>();
            services.AddTransient<ISnackService, SnackService>();


            return services;
        }
    }
}