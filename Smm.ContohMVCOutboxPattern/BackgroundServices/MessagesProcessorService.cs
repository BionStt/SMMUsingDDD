using Smm.ContohMVCOutboxPattern.DDD.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smm.ContohMVCOutboxPattern.BackgroundServices
{
    public class MessagesProcessorService : BackgroundService
    {
        private readonly ILogger<MessagesProcessorService> _logger;
        private readonly MessageProcessorServiceOptions _options;
        private readonly IServiceScopeFactory _scopeFactory;

        public MessagesProcessorService(ILogger<MessagesProcessorService> logger, MessageProcessorServiceOptions options, IServiceScopeFactory scopeFactory)
        {
            _logger=logger;
            _options=options;
            _scopeFactory=scopeFactory;
        }

        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Hosted service is stopping.");
            await base.StopAsync(stoppingToken);
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("\n---Processing messages:\n");
            while (!cancellationToken.IsCancellationRequested)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var processor = scope.ServiceProvider
                        .GetRequiredService<IMessageProcessor>();

                    await processor
                        .ProcessMessages(_options.BatchSize, cancellationToken);

                    await Task.Delay(TimeSpan.FromSeconds(_options.IntervalOnSeconds), cancellationToken);
                }
            }
        }


    }
}
