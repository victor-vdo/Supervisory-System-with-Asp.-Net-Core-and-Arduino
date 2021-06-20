using Microsoft.Extensions.DependencyInjection;
using Supervisory.Domain.Interfaces.Repositories;
using Supervisory.Domain.Interfaces.Services;
using Supervisory.Domain.Services;
using Supervisory.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supervisory.Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ITemperatureRepository, TemperatureRepository>();
            services.AddScoped<ITemperatureService, TemperatureService>();
            return services;
        }
    }
}
