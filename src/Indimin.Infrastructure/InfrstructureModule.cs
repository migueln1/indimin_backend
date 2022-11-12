using Indimin.Core.Common.Abstractions;
using Indimin.Core.Models;
using Indimin.Infrastructure.Data;
using Indimin.Infrastructure.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Indimin.Infrastructure;
public static class InfrstructureModule
{
    public static IServiceCollection AddInfrastructureConfig(
            this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<IndiminDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("IndiminConnString")));
           
        services.AddTransient<IRepository<Citizen, int>, CitizenRepository>();
        return services;
    }
}
