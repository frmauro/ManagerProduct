using CleanArchMvc.Infra.Data.Repositories;
using ManagerProduct.Domain.Interfaces;
using ManagerProduct.Infra.Data.Context;
using ManagerProduct.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ManagerProduct.Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {

        var connectionString = configuration["MySqlConnection:MySqlConnectionString"];
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(connectionString, new MySqlServerVersion(new Version(5, 7)),
            b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        // services.AddDbContext<ApplicationDbContext>(options =>
        //  options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
        // ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        return services;
    }
}
