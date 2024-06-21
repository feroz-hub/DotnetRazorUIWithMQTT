namespace MqttMainScreen.Models;

public class MqttClientRegistration
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public List<string> SubscribedTopics { get; set; }
    public DateTime LastConnected { get; set; }
    public DateTime LastDisconnected { get; set; }
    public bool IsConnected { get; set; }
    public int KeepAlive { get; set; }
    public string IpAddress { get; set; }
    
    
    
}
public class MqttClientRegistrationDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime Created { get; set; }
    public List<string> SubscribedTopics { get; set; }
    public int KeepAlive { get; set; }
}