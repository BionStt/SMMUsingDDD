using Smm.ContohMvcCQRSEventSourcing.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRSEventSourcing.Persistence.Event
{
    public class MessageProcessor : IMessageProcessor
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMessagePublisher _publisher;
        private readonly ILogger<MessageProcessor> _logger;

        public MessageProcessor(IMessagePublisher publisher, ILogger<MessageProcessor> logger, ApplicationDbContext dbContext)
        {
            _publisher = publisher ?? throw new ArgumentNullException(nameof(publisher));
     
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _dbContext=dbContext;
        }

        public async Task ProcessMessages(int batchSize, CancellationToken cancellationToken)
        {
            var messages = await _dbContext.StoredEvents.
                FetchUnprocessed(batchSize, cancellationToken);

            foreach (var message in messages)
            {
                try
                {
                    await _publisher.Publish(message, cancellationToken);

                    message.SetProcessedAt(DateTime.Now);
                    _dbContext.StoredEvents.UpdateProcessedAt(message);

                    await _dbContext.SaveChangesAsync();

                    _logger.LogInformation($"\n--- Message {message.Id} processed at {message.ProcessedAt}\n");
                }
                catch (Exception ex)
                {
                    _logger.LogError($"\n--- An error has occurred while processing message {message.Id}: {ex.Message}\n");
                }
            }
        }
    }
}
