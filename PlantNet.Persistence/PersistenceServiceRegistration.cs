using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlantNet.Application.Contracts.Persistence;
using PlantNet.Domain.Contracts.Persistence;
using PlantNet.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PlantNetDbContext>(options =>

                options.UseSqlServer(configuration.GetConnectionString("PlantNetConnectionString")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<ISpeciesRepository, SpeciesRepository>();
            services.AddScoped<IPlantRepository, PlantRepository>();
            
            return services;
        }
        
    }
}
