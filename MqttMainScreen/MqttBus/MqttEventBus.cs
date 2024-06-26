namespace MqttMainScreen.MqttBus;
public class MqttEventBus(ISender mediator,IMqttClient mqttClient,IServiceScopeFactory scopeFactory,IManagedMqttClient managedMqttClient):IMqttEventBus
{
    private readonly MqttFactory _mqttFactory=new() ;
    public async Task ManagedMqttPublish<T>(T message, string topic) where T : class
    {
        var data = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

        if (ConnectManagedMqttClient() && managedMqttClient != null)
        {

            await managedMqttClient.EnqueueAsync(new MqttApplicationMessage()
            {
                Topic = topic,
                PayloadSegment = data,
                QualityOfServiceLevel = MqttQualityOfServiceLevel.AtLeastOnce,
                Retain = true
            });
        }
    }
    
    private bool ConnectManagedMqttClient()
    {
        var result = false;
        try
        {
            if (managedMqttClient== null || !managedMqttClient.IsConnected)
            {
                var managedClientOption = new MqttClientOptionsBuilder()
                    .WithClientId("AdminManagedMqttClient")
                    .WithTcpServer("localhost", 1883)
                    .WithWillQualityOfServiceLevel(MqttQualityOfServiceLevel.AtLeastOnce)
                    .WithCleanSession(true)
                    .WithKeepAlivePeriod(TimeSpan.FromHours(2));
                managedMqttClient = _mqttFactory.CreateManagedMqttClient();

                var managedMqttClientOption = new ManagedMqttClientOptionsBuilder()
                    .WithClientOptions(managedClientOption)
                    .WithMaxPendingMessages(10)
                    //.WithPendingMessagesOverflowStrategy(MqttPendingMessagesOverflowStrategy.DropOldestQueuedMessage)
                    .WithAutoReconnectDelay(TimeSpan.FromSeconds(1))
                    .Build();
                managedMqttClient.StartAsync(managedMqttClientOption);
                result = true;
            }
        }
        catch (Exception ex)
        {
            result = false;
        }
        return result;
    }

}

