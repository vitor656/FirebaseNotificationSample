using FirebaseNotificationSample.Application.Interfaces.Repositories;
using FirebaseNotificationSample.Persistence.Data;
using FirebaseNotificationSample.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FirebaseNotificationSample.Persistence.Extensions
{
    public static class ConfigureRepositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<DataProvider>();
            services.AddScoped<INotificationRepository, NotificationRepository>();

            return services;
        }
        
    }
}