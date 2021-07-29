using FirebaseNotificationSample.Application.Interfaces;
using FirebaseNotificationSample.Application.Interfaces.Services;
using FirebaseNotificationSample.Infra.Firebase;
using Microsoft.Extensions.DependencyInjection;

namespace FirebaseNotificationSample.Infra.Extensions
{
    public static class ConfigureFirebase
    {
        public static IServiceCollection AddFirebase(this IServiceCollection services, string credentials)
        {
            services.AddSingleton<FirebaseAppProvider>(f => new FirebaseAppProvider("key.json"));
            services.AddScoped<IFirebaseNotificationService, FirebaseNotificationService>();

            return services;
        }
        
    }
}