using Indimin.Application.Citizens;
using Indimin.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Indimin.Application;

public static class ApplicationModule
{
    public static IServiceCollection AddApplicationConfig(
            this IServiceCollection services, IConfiguration config)
    {
        services.AddInfrastructureConfig(config);
        services.AddTransient<ICitizenService, CitizenService>();

        return services;
    }
}

