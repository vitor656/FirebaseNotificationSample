using System;

namespace FirebaseNotificationSample.Domain.Models
{
    public class NotificationModel : Entity
    {
        public NotificationModel(string title, string description, string url, string urlDescription) : base()
        {
            this.Title = title;
            this.Description = description;
            this.Url = url;
            this.UrlDescription = urlDescription;

        }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Url { get; private set; }
        public string UrlDescription { get; private set; }

    }
}