using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PetBreeders.Application.Common.Interfaces;

namespace PetBreeders.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<PetBreedersDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("PetBreedersDatabase")));
        services.AddScoped<IPetBreedersDbContext, PetBreedersDbContext>();
        return services;
    }
}
