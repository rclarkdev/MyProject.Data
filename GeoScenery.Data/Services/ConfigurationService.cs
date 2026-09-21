using Microsoft.Extensions.Configuration;
using System.IO;

namespace GeoScenery.Data.Services
{
    public static class ConfigurationService
    { 
        public static IConfigurationBuilder IConfigurationBuilder()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            return builder;
        }

    }
}
