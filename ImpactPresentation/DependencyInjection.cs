
using Microsoft.Extensions.DependencyInjection;

namespace ImpactApplication;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services) 
    {
        var assemply = typeof(DependencyInjection).Assembly;

        services.AddMediatR(configuration =>
            configuration.RegisterServicesFromAssembly(assemply));

       

        return services;

    }
}
