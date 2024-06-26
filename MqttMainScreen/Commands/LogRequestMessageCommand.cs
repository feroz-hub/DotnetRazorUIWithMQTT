using MqttMainScreen.Models;

namespace MqttMainScreen.Commands;

public class LogRequestMessageCommand(MqttLogRequest mqttLogRequest):IRequest<bool>
{
    public MqttLogRequest LogRequest => new()
    {
        RequestId = Guid.NewGuid(),
        RequestDate = DateTime.Now,
        SourceId = mqttLogRequest.SourceId,
        TargetId = mqttLogRequest.TargetId,
        LogRequestDto = mqttLogRequest.LogRequestDto,
    };
}