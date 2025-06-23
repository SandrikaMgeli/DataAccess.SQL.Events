namespace DataAccess.SQL.Events.Abstraction.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ConsumeAttribute(string EventName) : Attribute;