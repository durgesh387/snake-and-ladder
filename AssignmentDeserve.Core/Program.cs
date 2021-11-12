using System;
using Microsoft.Extensions.DependencyInjection;

namespace AssignmentDeserve.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //using var host = CreateHostBuilder(args).Build();
            var services=Startup.ConfigureServices();
            var serviceProvider=services.BuildServiceProvider();
            serviceProvider.GetService<EntryPoint>().Run();
            //await host.RunAsync();
        }
    }
}
