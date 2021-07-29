using AutoMapper;
using FirebaseNotificationSample.Application.Dto;
using FirebaseNotificationSample.Domain.Models;

namespace FirebaseNotificationSample.Application.Mapping
{
    public class NotificationMapping : Profile
    {
        public NotificationMapping()
        {
            CreateMap<NotificationDto, NotificationModel>();
            CreateMap<NotificationModel, NotificationDto>();
        }
    }
}