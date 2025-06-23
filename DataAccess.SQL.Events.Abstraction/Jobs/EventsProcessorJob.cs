using DataAccess.SQL.Events.Abstraction.Jobs.Base;
using DataAccess.SQL.Events.Abstraction.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DataAccess.SQL.Events.Abstraction.Jobs;

public class EventsProcessorJob(
    ILogger<EventsProcessorJob> logger,
    IServiceScopeFactory serviceScopeFactory)
    : Job(logger, TimeSpan.FromMinutes(1))
{
    protected override async Task InvokeAsync(CancellationToken stoppingToken)
    {
        using IServiceScope scope = serviceScopeFactory.CreateScope();

        IEventsProcessorService eventsProcessor = scope.ServiceProvider.GetRequiredService<IEventsProcessorService>();
        await eventsProcessor.ProcessEvents(stoppingToken);
    }
}