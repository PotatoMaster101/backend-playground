using RabbitMQ.Client;

namespace Protocols.PublishSubscribe;

/// <summary>
/// Factory for RabbitMQ connections.
/// </summary>
public static class RabbitMqFactory
{
    /// <summary>
    /// Returns a new RabbitMQ connection.
    /// </summary>
    public static Task<IConnection> GetConnection()
    {
        var factory = new ConnectionFactory
        {
            UserName = "guest",
            Password = "guest",
            HostName = "localhost"
        };
        return factory.CreateConnectionAsync();
    }
}
