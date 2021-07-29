using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FirebaseNotificationSample.Application.Dto;
using FirebaseNotificationSample.Application.Interfaces.Services;
using FirebaseNotificationSample.Application.Operations.Commands;
using FirebaseNotificationSample.Application.Operations.Queries;
using FirebaseNotificationSample.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FirebaseNotificationSample.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator mediator;

        public HomeController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> SendNotificationAsync(SendNotificationCommand notificationCommand)
        {
            await mediator.Publish(notificationCommand);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<List<NotificationDto>>> GetAll()
        {
            return await mediator.Send(new GetAllNotificationsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<NotificationDto>> GetOne(Guid id)
        {
            return await mediator.Send(new GetOneNotificationQuery(id));
        }
    }
}