namespace DataAccess.SQL.Events.Abstraction.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ProduceAttribute(string topicName, string eventName) : Attribute;