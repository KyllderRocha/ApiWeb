using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ApiWeb
{
    public class Configurations 
    {
        public string Mongo { get; set; }
        public string Database { get; set; }

        public Configurations()
        {
            var configuration = new ConfigurationBuilder()
                                    .AddJsonFile($"appsettings.json")
                                    .Build();

            new ConfigureFromConfigurationOptions<Configurations>(configuration.GetSection("ConnectionStrings")).Configure(this);

        }
    }
}
