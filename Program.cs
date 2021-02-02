using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.IO;
using System.Net.Mail;

namespace ConfigurationsForConsoleApps
{
    class Program
    {
        public static IConfigurationRoot configuration;

        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var mailService = serviceProvider.GetRequiredService<MailService>();
            mailService.DoWork();
        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(c => c.AddConsole());

            configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            services.Configure<ConfigurationContainer>(configuration.Bind);
            services.AddTransient<MailService>();
        }
    }
}
