using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DataAccess.SQL.Events.Abstraction;

public class EventsProcessorJob(
    ILogger<EventsProcessorJob> logger)
    : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {

            }
            catch (Exception e)
            {
                logger.LogError(e, e.Message);
            }
            finally
            {
                await Task.Delay(1000, CancellationToken.None);
            }
        }
    }
}