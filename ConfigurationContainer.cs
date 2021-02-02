namespace ConfigurationsForConsoleApps
{
    public class ConfigurationContainer
    {
        public string ConnectionString { get; set; }

        public SmtpConfiguration Smtp { get; set; }
    }
}
