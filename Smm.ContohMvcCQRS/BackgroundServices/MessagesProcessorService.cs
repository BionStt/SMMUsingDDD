using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Smm.ContohMvcCQRS.Data.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Smm.ContohMvcCQRS.BackgroundServices
{
    public class MessagesProcessorService : BackgroundService
    {
        private readonly ILogger<MessagesProcessorService> _logger;
        private readonly MessageProcessorServiceOptions _options;
        private readonly IServiceScopeFactory _scopeFactory;

        public MessagesProcessorService(
            MessageProcessorServiceOptions options,
            IServiceScopeFactory scopeFactory,
            ILogger<MessagesProcessorService> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _options = options ?? throw new ArgumentNullException(nameof(options));
            _scopeFactory = scopeFactory ?? throw new ArgumentNullException(nameof(scopeFactory));
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

        public override async Task StopAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Hosted service is stopping.");
            await base.StopAsync(stoppingToken);
        }
    }
}
