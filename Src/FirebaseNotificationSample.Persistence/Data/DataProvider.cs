using System.Collections.Generic;
using FirebaseNotificationSample.Domain.Models;

namespace FirebaseNotificationSample.Persistence.Data
{
    public class DataProvider
    {
        public List<NotificationModel> Notifications { get; private set; }

        public DataProvider()
        {
            Notifications = new List<NotificationModel>() 
            {
                new NotificationModel(
                    "Title",
                    "Description",
                    "https://google.com",
                    "Url to google"
                ),
                new NotificationModel(
                    "Title",
                    "Description",
                    "https://google.com",
                    "Url to google"
                ),
                new NotificationModel(
                    "Title",
                    "Description",
                    "https://google.com",
                    "Url to google"
                )
            };
        }
        
    }
}