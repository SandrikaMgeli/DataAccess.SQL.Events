using DataAccess.SQL.Abstraction;

namespace DataAccess.SQL.Events.PostgreSql.Kafka;

public static class Extensions
{
    /// <summary>
    /// It is just experimental project which shows us paradigm how it should be implemented.
    /// In real world Events persistence project [PostgreSql] and Transport [Kafka] should be
    /// seperated projects and one implements transport and other persistence.
    /// They should have seperated Add methods like this:
    /// AddPostgreSql() - implements persistence
    /// AddKafka() - implements kafka
    /// Because of this architectural design, both of them are totally seperated modules of application,
    /// so they can be implemented in totally seperated manner
    /// </summary>
    public static DbOptions AddPostgreSqlKafka(this DbOptions options)
    {
        return options;
    }
}