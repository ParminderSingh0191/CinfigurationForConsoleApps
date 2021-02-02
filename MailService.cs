using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace ConfigurationsForConsoleApps
{
    public class MailService
    {
        private readonly ILogger<MailService> logger;

        private readonly IOptions<ConfigurationContainer> options;

        public MailService(ILogger<MailService> logger, IOptions<ConfigurationContainer> options)
        {
            this.logger = logger;
            this.options = options;
        }

        public void DoWork()
        {
            logger.LogInformation($"Connection string {options.Value.ConnectionString}");
        }
    }
}
