using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace SteamDataCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            var settings = new Settings();
            configuration.Bind(settings);

            Console.WriteLine($"ApplicationName is '{settings.ApplicationName}'");
            Console.WriteLine($"ApiKey is '{settings.ApiKey}'");
        }
    }
}
