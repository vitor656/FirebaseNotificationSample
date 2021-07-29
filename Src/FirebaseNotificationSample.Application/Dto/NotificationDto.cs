using System;

namespace FirebaseNotificationSample.Application.Dto
{
    public class NotificationDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlDescription { get; set; }
    }
}