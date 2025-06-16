using DataAccess.SQL.Abstraction;
using DataAccess.SQL.Events.Abstraction;

namespace DataAccess.SQL.Events.PostgreSql.Kafka;

public class EventsPublisher(DbContext context) : IEventsPublisher
{
    public Task PublishAsync<T>(T message, PublishOptions? publishOptions)
    {
        throw new NotImplementedException();
    }
}