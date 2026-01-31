using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace PizzaApp.Storage;

public static class StorageModule
{
    public static IServiceCollection AddStorage(
        this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(connectionString));
        return services;
    }
}