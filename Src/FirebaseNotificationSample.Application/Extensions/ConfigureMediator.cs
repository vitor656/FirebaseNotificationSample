using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace FirebaseNotificationSample.Application.Extensions
{
    public static class ConfigureMediator
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ConfigureMediator).Assembly);
            return services;
        }
        
    }
}