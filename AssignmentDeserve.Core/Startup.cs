using Microsoft.Extensions.DependencyInjection;

namespace AssignmentDeserve.Core{
    public static class Startup{
        public static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddSingleton<EntryPoint>();
            services.AddSingleton<DiceFactory>();
            services.AddSingleton<IGameService,GameService>();
            services.AddTransient<IRollable,SingleDice>();
            services.AddTransient<IRollable,EvenCrookedDice>();
            services.AddTransient<IRollable,OddCrookedDice>();

            return services;
        }
    }
}