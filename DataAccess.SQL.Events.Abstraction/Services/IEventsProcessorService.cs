namespace DataAccess.SQL.Events.Abstraction.Services;

public interface IEventsProcessorService
{
    Task ProcessEvents(CancellationToken cancellationToken);
}