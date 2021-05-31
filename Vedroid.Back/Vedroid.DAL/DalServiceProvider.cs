using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Vedroid.DAL.Context;
using Vedroid.DAL.Interfaces;

namespace Vedroid.DAL
{
    public static class DalServiceProvider
    {
        public static IServiceCollection RegisterDalServices(this IServiceCollection services,
            string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork.UnitOfWork));

            return services;
        }
    }
}