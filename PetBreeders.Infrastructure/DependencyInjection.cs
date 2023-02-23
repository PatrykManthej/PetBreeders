using Microsoft.Extensions.DependencyInjection;
using PetBreeders.Application.Common.Interfaces;
using PetBreeders.Infrastructure.ExternalAPI.DogApi;
using PetBreeders.Infrastructure.FileStore;
using PetBreeders.Infrastructure.Services;

namespace PetBreeders.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddHttpClient("DogApiClient", options =>
        {
            options.BaseAddress = new Uri("http://api.thedogapi.com");
            options.Timeout = new TimeSpan(0, 0, 10);
            options.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }).ConfigurePrimaryHttpMessageHandler(sp => new HttpClientHandler());

        services.AddScoped<IDogApiClient, DogApiClient>();

        services.AddTransient<IDateTime, DateTimeService>();
        services.AddTransient<IFileStore, FileStore.FileStore>();
        services.AddTransient<IFileWrapper, FileWrapper>();
        services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();
        return services;
    }
}
