using MediatR;
using MqttMainScreen.Services.Interfaces;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;

namespace MqttMainScreen.MqttBus;
public class MqttEventBus(ISender mediator,IMqttClient mqttClient,IServiceScopeFactory scopeFactory,IManagedMqttClient managedMqttClient):IMqttEventBus
{
    public async Task ManagedMqttPublish<T>(T message, string topic) where T : class
    {
        throw new NotImplementedException();
    }
}

