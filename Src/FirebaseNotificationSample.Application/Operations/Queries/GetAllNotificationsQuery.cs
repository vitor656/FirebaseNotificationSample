using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FirebaseNotificationSample.Application.Dto;
using FirebaseNotificationSample.Application.Interfaces.Repositories;
using MediatR;

namespace FirebaseNotificationSample.Application.Operations.Queries
{
    public class GetAllNotificationsQuery : IRequest<List<NotificationDto>>
    {
        
    }

    public class GetAllNotificationsHandler : IRequestHandler<GetAllNotificationsQuery, List<NotificationDto>>
    {
        private readonly INotificationRepository repository;
        private readonly IMapper mapper;

        public GetAllNotificationsHandler(INotificationRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public Task<List<NotificationDto>> Handle(GetAllNotificationsQuery request, CancellationToken cancellationToken)
        {
            var notifications = repository.GetAll().Select(c => mapper.Map<NotificationDto>(c)).ToList();
            return Task.FromResult<List<NotificationDto>>(notifications);
        }
    }
}