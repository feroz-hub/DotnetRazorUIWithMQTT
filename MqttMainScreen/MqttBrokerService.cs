using MqttMainScreen.Infrastructure;
using MQTTnet;
using MQTTnet.Protocol;
using MQTTnet.Server;

namespace MqttMainScreen;

public class MqttBrokerService(IMqttClientRepository  mqttClientRepository)
{

    public  async Task ServerConnection()
    {
        var mqttFactory = new MqttFactory();
        var options = new MqttServerOptionsBuilder()
            .WithDefaultEndpoint().Build();
        // List<string> allowedClientIds = ["Client1", "Client2", "Test"];
        using var mqttServer = mqttFactory.CreateMqttServer(options);
        mqttServer.ValidatingConnectionAsync += async e =>
        {
            var allowedClientIds = await mqttClientRepository.GetAllClient();
            if (!allowedClientIds.Contains(e.ClientId))
            {
                e.ReasonCode = MqttConnectReasonCode.ClientIdentifierNotValid;
            }
            ;
        };
        await mqttServer.StartAsync();
        await mqttServer.StopAsync();
    }
    
}