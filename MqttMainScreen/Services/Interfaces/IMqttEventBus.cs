namespace MqttMainScreen.Services.Interfaces;

public interface IMqttEventBus
{
    Task ManagedMqttPublish<T>(T message,string topic) where T : class;
}