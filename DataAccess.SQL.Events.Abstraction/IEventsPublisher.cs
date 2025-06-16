namespace DataAccess.SQL.Events.Abstraction;

public interface IEventsPublisher
{
    Task PublishAsync<T>(T message, PublishOptions? publishOptions = null);
}