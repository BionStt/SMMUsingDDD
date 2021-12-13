using Smm.ContohMVCOutboxPattern.DDD.EventDomainEntity;
using Smm.ContohMVCOutboxPattern.DDD.Events;
using Smm.ContohMVCOutboxPattern.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.Persistence.Event
{
    public class MessageProcessor : IMessageProcessor
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMessagePublisher _publisher;
        private readonly ILogger<MessageProcessor> _logger;

        private readonly IStoredEvents _eventStore;
        public MessageProcessor(ApplicationDbContext dbContext, IMessagePublisher publisher, ILogger<MessageProcessor> logger, IStoredEvents eventStore)
        {
            _dbContext=dbContext;
            _publisher=publisher;
            _logger=logger;
            _eventStore=eventStore;
        }

        public async Task ProcessMessages(int batchSize, CancellationToken cancellationToken)
        {
            var messages = await _eventStore.FetchUnprocessed(batchSize, cancellationToken);
            //var messages = await _dbContext.StoredEvents.
            //     FetchUnprocessed(batchSize, cancellationToken);

            foreach (var message in messages)
            {
                try
                {
                    await _publisher.Publish(message, cancellationToken);

                    message.SetProcessedAt(DateTime.Now);

                     _dbContext.StoredEvent.Update(message);

                  //  _dbContext.StoredEvents.UpdateProcessedAt(message);

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
