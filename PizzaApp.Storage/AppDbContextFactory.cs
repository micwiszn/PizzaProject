using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PizzaApp.Storage;

public sealed class AppDbContextFactory
    : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseNpgsql(
                "Host=localhost;Port=5432;Database=appdb;Username=postgres;Password=defaultPsswd")
            .Options;

        return new AppDbContext(options);
    }
}