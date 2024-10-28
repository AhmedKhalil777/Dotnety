namespace Dotnety.Models;

public class Connection
{
    public int Id { get; set; }
    public string ConnectionName { get; set; } = default!;
    public string ConnectionString { get; set; } = default!;
    public string Analyzer { get; set; } = default!;
    public ConnectionType ConnectionType { get; set; }
}


public enum ConnectionType
{
    SQLServer,
    MySQL,
    Oracle,
    AzureBlobStorage,
    Kafka,
    RabbitMQ,
}
