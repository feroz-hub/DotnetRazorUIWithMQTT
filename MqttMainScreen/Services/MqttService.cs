using MqttMainScreen.Models;
using MqttMainScreen.Services.Interfaces;

namespace MqttMainScreen.Services;

public class MqttService:IMqttService
{
    public async Task<bool> LogRequestPublishAsync(MqttLogRequest mqttLogRequest)
    {
        throw new NotImplementedException();
    }
}