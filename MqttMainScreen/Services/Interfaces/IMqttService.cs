using MqttMainScreen.Models;

namespace MqttMainScreen.Services.Interfaces;

public interface IMqttService
{
    public Task<bool> LogRequestPublishAsync(MqttLogRequest mqttLogRequest);
}