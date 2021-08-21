using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Smm.ContohMvcCQRS.Data;
using Smm.ContohMvcCQRS.Domain.Events;
using Smm.ContohMvcCQRS.Services;
using Microsoft.EntityFrameworkCore;

namespace Smm.ContohMvcCQRS.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class DataKonsumenRegisteredEventHandler : INotificationHandler<DataKonsumenRegisteredEvent>
    {
        private readonly IMediator _mediator;
        private readonly IEmailSender _emailSender;
     //   private readonly ApplicationDbContext _dbContext;
        public DataKonsumenRegisteredEventHandler(IMediator mediator, IEmailSender emailSender)//, ApplicationDbContext dbContext)
        {
            _mediator = mediator;
            _emailSender = emailSender;
          //  _dbContext = dbContext;
        }
        public async Task Handle(DataKonsumenRegisteredEvent notification, CancellationToken cancellationToken)
        {
            //var email = _dbContext.DataKonsumen.Where(x => x.Id == notification.DataKonsumenId).FirstOrDefaultAsync();
            // sending email
          //  await _emailSender.SendEmailAsync(notification.Email,"Selamat datang","halo gan");

            //await _mediator.Publish(new MarkDataKonsumenAsWelcomedCommand(notification.DataKonsumenId));
              await _mediator.Send(new MarkDataKonsumenAsWelcomedCommand(notification.DataKonsumenId));
        }
    }
}
