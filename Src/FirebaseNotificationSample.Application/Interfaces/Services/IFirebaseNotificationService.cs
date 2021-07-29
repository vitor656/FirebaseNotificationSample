using System.Threading.Tasks;
using FirebaseNotificationSample.Domain.Models;

namespace FirebaseNotificationSample.Application.Interfaces.Services
{
    public interface IFirebaseNotificationService
    {
        public Task SendNotificationAsync(NotificationModel notification, string destinationToken);
    }
}