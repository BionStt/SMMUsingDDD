using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Smm.ContohMvcCQRS.Data;
using Smm.ContohMvcCQRS.Services;

namespace Smm.ContohMvcCQRS.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenNotificationHandler : INotificationHandler<CreateDataKonsumenNotification>
    {
        private readonly IMediator _mediator;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _dbContext;

        public CreateDataKonsumenNotificationHandler(IMediator mediator, IEmailSender emailSender, ApplicationDbContext dbContext)
        {
            _mediator = mediator;
            _emailSender = emailSender;
            _dbContext = dbContext;
        }

        public async Task Handle(CreateDataKonsumenNotification notification, CancellationToken cancellationToken)
        {
            var email = _dbContext.DataKonsumen.Where(x => x.Id == notification.DataKonsumenId).FirstOrDefaultAsync();
            // sending email
            await _emailSender.SendEmailAsync(email.Result.Email, "Selamat datang", "halo gan");
            await _mediator.Send(new MarkDataKonsumenAsWelcomedCommand(notification.DataKonsumenId));
           // await _mediator.Publish(new MarkDataKonsumenAsWelcomedCommand(notification.DataKonsumenId));
        }
    }
}
