namespace MqttMainScreen;

public class MqttService
{
    private readonly IMqttClient _mqttClient;
    private readonly ConcurrentBag<string> _messages;
    public readonly ConcurrentBag<string>  _subscribedTopics;

    private readonly MqttClientOptions _options;
    public MqttService()
    {
        var factory = new MqttFactory();
        _mqttClient = factory.CreateMqttClient();
        _messages = new ConcurrentBag<string>();
        _subscribedTopics = new ConcurrentBag<string>();

        
        _options = new MqttClientOptionsBuilder()
            .WithTcpServer("localhost", 1883)
            .WithClientId("Client2_Subscriber")
            .WithWillQualityOfServiceLevel(MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce)
            .Build();

        _mqttClient.ApplicationMessageReceivedAsync += async e =>
        {
            var message = $"Received Message on Topic: '{e.ApplicationMessage.Topic}' with Content '{e.ApplicationMessage.ConvertPayloadToString()}'";
            _messages.Add(message);
            await Task.CompletedTask;
        };

        _mqttClient.ConnectAsync(_options, CancellationToken.None).Wait();
        
        _mqttClient.DisconnectedAsync += async e =>
        {
            await Task.Delay(TimeSpan.FromSeconds(5)); // Wait before reconnecting
            try
            {
                await _mqttClient.ConnectAsync(_options, CancellationToken.None);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Reconnecting failed: " + ex.Message);
            }
        };
        SubscribeToTopics([
            "clear_tpm", "change_password", "seal_hash", "un_seal_hash", "delete_hash", "store_encryption_key",
            "get_encryption_key", "delete_encryption_key"
        ]).Wait();
    }
    
    private async Task ConnectClient()
    {
        try
        {
            await _mqttClient.ConnectAsync(_options, CancellationToken.None);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Connection failed: " + ex.Message);
        }
    }

    private bool IsConnected => _mqttClient.IsConnected;

    private async Task SubscribeToTopics(List<string> topics)
    {
        foreach (var topic in topics)
        {
            var sub = await _mqttClient.SubscribeAsync(topic);
            _subscribedTopics.Add(topic);
            // Handle subscription result if needed
        }
    }
    
    public async Task SubscribeToTopic(string topic)
    {
        if (!IsConnected)
        {
            await ConnectClient();
        }
        if (IsConnected)
        {
            await _mqttClient.SubscribeAsync(topic);
            _subscribedTopics.Add(topic);
        }
        else
        {
            throw new InvalidOperationException("MQTT client is not connected.");
        }
    }
    
    public IEnumerable<string> GetMessages()
    {
        return _messages;
    }
    public IEnumerable<string> GetSubscribedTopics()
    {
        return _subscribedTopics.Distinct();
    }
    
}