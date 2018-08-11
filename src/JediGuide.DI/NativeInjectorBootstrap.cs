using Microsoft.Extensions.DependencyInjection;

namespace JediGuide.DI
{
    public class NativeInjectorBootstrap
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //services.AddScoped<IEventRepository, EventRepository>();
        }
    }
}