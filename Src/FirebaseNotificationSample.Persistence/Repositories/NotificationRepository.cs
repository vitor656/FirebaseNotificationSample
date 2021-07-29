using System.Collections.Generic;
using FirebaseNotificationSample.Application.Interfaces.Repositories;
using FirebaseNotificationSample.Domain.Models;
using FirebaseNotificationSample.Persistence.Data;

namespace FirebaseNotificationSample.Persistence.Repositories
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly DataProvider data;

        public NotificationRepository(DataProvider data)
        {
            this.data = data;
        }
        public List<NotificationModel> GetAll()
        {
            return data.Notifications;
        }
    }
}