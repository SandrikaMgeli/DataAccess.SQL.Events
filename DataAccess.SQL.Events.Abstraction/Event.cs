namespace DataAccess.SQL.Events.Abstraction;

public class Event
{
    /// <summary>
    /// Event identifier. if this identifier is smaller, that means that event came earlier then the event which has bigger identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// This field comes from kafka, and it is time of sending event in UTC.
    /// </summary>
    public DateTime EventPublishedAt { get; set; }

    /// <summary>
    /// This field gives us time of last update of row. If null, row was not updated at all.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// This field gives us time of row creation.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Name of the event.
    /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public string EventType { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public string PartitionKey { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
    public string IdempotencyKey { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

    public string? Data { get; set; }
}