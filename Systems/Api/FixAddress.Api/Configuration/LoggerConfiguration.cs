namespace FixAddress.Api.Configuration;

using Serilog;


public static class LoggerConfiguration
{
    /// <summary>
    /// Добавляет Logger
    /// </summary>
    public static void AddAppLogger(this WebApplicationBuilder builder)
    {
        var logger = new Serilog.LoggerConfiguration()
            .Enrich.WithCorrelationIdHeader()
            .Enrich.FromLogContext()
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();

        builder.Host.UseSerilog(logger, true);
    }
}