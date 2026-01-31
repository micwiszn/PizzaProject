using Microsoft.EntityFrameworkCore;
using PizzaApp.Storage.Models;

namespace PizzaApp.Storage;

public sealed class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users => Set<User>();
    
}