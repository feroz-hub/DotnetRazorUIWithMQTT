using MqttMainScreen.Commands;
using MqttMainScreen.Models;

namespace MqttMainScreen.Services;

public class MqttService(IMediator mediator):IMqttService
{
    public async Task<bool> LogRequestPublishAsync(MqttLogRequest mqttLogRequest)
    {
        var logRequestMessageCommand = new LogRequestMessageCommand(mqttLogRequest);
        await mediator.Send(logRequestMessageCommand);
        return true;
    }
}