using Application.Common.Interfaces;
using ImpactBackend.Infrastructure.Persistence;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Configuration;
namespace Microsoft.Extensions.DependencyInjection;


public static class ConfigureServices
{
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"],
			b => b.MigrationsAssembly("Infrastructure")));

		services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        services.AddScoped<ApplicationDbContextInitialiser>();

        //Add - Migration SampleMigration - Project "src\Infrastructure" - StartupProject "src\Web" - OutputDir "Persistence\Migrations"

        return services;
	}
}
