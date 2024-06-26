using MqttMainScreen.Commands;

namespace MqttMainScreen.Handlers;

public class LogRequestMessageCommandHandler(IMqttEventBus mqttEventBus):IRequestHandler<LogRequestMessageCommand,bool >
{
    public async Task<bool> Handle(LogRequestMessageCommand request, CancellationToken cancellationToken)
    {
        await mqttEventBus.ManagedMqttPublish(request.LogRequest, request.LogRequest.TargetId);
        return await Task.FromResult(true);
    }
}