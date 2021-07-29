using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FirebaseNotificationSample.Application.Dto;
using FirebaseNotificationSample.Application.Interfaces.Repositories;
using MediatR;

namespace FirebaseNotificationSample.Application.Operations.Queries
{
    public record GetOneNotificationQuery(Guid id) : IRequest<NotificationDto>;

    public class GetOneNotificationHandler : IRequestHandler<GetOneNotificationQuery, NotificationDto>
    {
        private readonly INotificationRepository repository;
        private readonly IMapper mapper;

        public GetOneNotificationHandler(INotificationRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        public Task<NotificationDto> Handle(GetOneNotificationQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(mapper.Map<NotificationDto>(repository.GetAll().Where(d => d.Id == request.id).FirstOrDefault()));
        }
    }
}