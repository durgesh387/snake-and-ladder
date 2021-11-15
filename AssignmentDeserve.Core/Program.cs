using System;
using Microsoft.Extensions.DependencyInjection;

namespace AssignmentDeserve.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services=Startup.ConfigureServices();
            var serviceProvider=services.BuildServiceProvider();
            serviceProvider.GetService<EntryPoint>().Run();
        }
    }
}
