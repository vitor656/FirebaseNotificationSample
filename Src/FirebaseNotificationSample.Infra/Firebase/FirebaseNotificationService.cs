using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FirebaseAdmin.Messaging;
using FirebaseNotificationSample.Application.Interfaces.Services;
using FirebaseNotificationSample.Domain.Models;

namespace FirebaseNotificationSample.Infra.Firebase
{
    public class FirebaseNotificationService : IFirebaseNotificationService
    {
        private readonly FirebaseAppProvider provider;

        public FirebaseNotificationService(FirebaseAppProvider provider)
        {
            this.provider = provider;
        }

        public async Task SendNotificationAsync(NotificationModel notification, string destinationToken)
        {
            var message = new Message()
            {
                Notification = new Notification(){
                    Title = notification.Title,
                    Body = notification.Description
                },
                Data = new Dictionary<string, string>{
                    { "Url", notification.Url },
                    { "UrlDescription", notification.UrlDescription }
                },
                Token = destinationToken
            };

            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);
            Console.WriteLine(response);
        }
    }
}