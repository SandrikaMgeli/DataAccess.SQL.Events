using DataAccess.SQL.Abstraction;

namespace DataAccess.SQL.Events.Abstraction.Services;

public class EventsProcessorService(IDbManager dbManager) : IEventsProcessorService
{
    public Task ProcessEvents(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}