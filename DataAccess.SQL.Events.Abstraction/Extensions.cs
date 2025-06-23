using DataAccess.SQL.Abstraction;
using DataAccess.SQL.Events.Abstraction.Jobs;
using DataAccess.SQL.Events.Abstraction.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.SQL.Events.Abstraction;

public static class Extensions
{
    public static DbOptions Configure(this DbOptions options)
    {
        options.Services.AddHostedService<EventsProcessorJob>();
        options.Services.AddScoped<IEventsProcessorService, EventsProcessorService>();
        return options;
    }
}