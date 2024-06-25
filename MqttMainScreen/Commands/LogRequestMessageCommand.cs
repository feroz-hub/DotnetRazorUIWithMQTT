using MediatR;
using MqttMainScreen.Models;

namespace MqttMainScreen.Commands;

public class LogRequestMessageCommand(MqttLogRequest mqttLogRequest):IRequest<bool>
{
    public MqttLogRequest LogRequest => new()
    {
        RequestId = Guid.NewGuid(),
        ActionType = mqttLogRequest.ActionType,
        IsAckRequired = mqttLogRequest.IsAckRequired,
        LogRequestDto = mqttLogRequest.LogRequestDto,
        RequestDate = DateTime.Now,
        SourceId = mqttLogRequest.SourceId,
        TargetId = mqttLogRequest.TargetId
    };
}