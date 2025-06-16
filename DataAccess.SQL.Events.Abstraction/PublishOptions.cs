namespace DataAccess.SQL.Events.Abstraction;

public class PublishOptions
{
    public string? IdempotencyKey { get; set; }

    public string? PartitionKey { get; set; }
}