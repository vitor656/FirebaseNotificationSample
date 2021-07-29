using Microsoft.Extensions.DependencyInjection;

namespace FirebaseNotificationSample.Application.Extensions
{
    public static class ConfigureMappings
    {
        public static IServiceCollection AddMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigureMappings).Assembly);
            
            return services; 
        }
        
    }
}