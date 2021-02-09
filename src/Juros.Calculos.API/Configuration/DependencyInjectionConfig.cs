using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;
using Juros.Business.Services;
using System;
using Microsoft.Extensions.Configuration;

namespace Juros.Calculos.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpClient<ITaxaJurosService, TaxaJurosService>(c =>
            {
                c.BaseAddress = new Uri(configuration["ApiTaxa"]);
            });

            services.AddScoped<ICalculoJurosService, CalculoJurosService>();            

            services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();

            return services;
        }
    }
}