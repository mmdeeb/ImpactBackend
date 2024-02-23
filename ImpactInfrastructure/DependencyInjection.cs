using ImpactInfrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ImpactInfrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        //services.AddDbContext<ImpactDbContext>(options =>
        //         options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;DataBase=ImpactDatabase;Trusted_Connection=True;"));

        //services.AddDbContext<ImpactDbContext>(options =>
        //         options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
        //         builder => builder.MigrationsAssembly(typeof(ImpactDbContext).Assembly.FullName)));

        return services;

    }
}
