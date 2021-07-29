using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FirebaseNotificationSample.Application.Interfaces.Repositories;
using FirebaseNotificationSample.Application.Interfaces.Services;
using MediatR;

namespace FirebaseNotificationSample.Application.Operations.Commands
{
    public record SendNotificationCommand(Guid id, string destinationToken) : INotification;

    public class SendNotificationCommandHandler : INotificationHandler<SendNotificationCommand>
    {
        private readonly INotificationRepository repository;
        private readonly IFirebaseNotificationService service;

        public SendNotificationCommandHandler(INotificationRepository repository, IFirebaseNotificationService service)
        {
            this.repository = repository;
            this.service = service;
        }
        public async Task Handle(SendNotificationCommand notification, CancellationToken cancellationToken)
        {
            var notificationEntity = repository.GetAll().Where(d => d.Id == notification.id).FirstOrDefault();
            await service.SendNotificationAsync(notificationEntity, notification.destinationToken);
        }
    }
}