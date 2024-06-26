namespace MqttMainScreen.Models;

public class Client
{
    public Guid ClientId { get; init; }
    public string DeviceName { get; init; } = default!;
    public DateTime Created { get; init; }
    public List<string> SubscribedTopics { get; init; }
    public DateTime LastAccessed { get; init; }
    public bool Status { get; init; }
    public int KeepAlive { get; init; }
    public string IpAddress { get; init; }
}
public class MqttClientRegistrationDto
{
    public Guid Id { get; set; }
    public string DeviceName { get; set; }
    public DateTime Created { get; set; }
    public List<string> SubscribedTopics { get; set; }
    public int KeepAlive { get; set; }
}