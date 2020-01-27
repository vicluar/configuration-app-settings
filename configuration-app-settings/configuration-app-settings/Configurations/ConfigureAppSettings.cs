using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace configuration_app_settings.Configurations
{
    public static class ConfigureAppSettings
    {
        public static IServiceCollection AddAppSettings(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration);
            services.Configure<MySecondLevelConfig>(configuration.GetSection("MyHeadConfiguration").GetSection("MySecondLevelConfig"));
            return services;
        }
    }
}
