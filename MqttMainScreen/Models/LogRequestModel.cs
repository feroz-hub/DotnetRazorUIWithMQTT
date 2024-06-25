namespace MqttMainScreen.Models;


public class MqttLogRequest
{
    public Guid RequestId { get; set; }
    public string TargetId { get; init; }=default!;
    public string SourceId { get; init; } = default!;
    public DateTime RequestDate { get; set; }
    public LogRequestDto LogRequestDto { get; init; } = default!;
}
public class LogRequestDto
{
    public List<LogType>  LogTypes { get; init; }=default!;
    public List<LogLevel> LogLevels { get; init; }=default!;
    public bool IsAckRequired { get; init; } 
    public ActionType ActionType { get; init; }
    public ResponseType ResponseType { get; init; }
    public DateTime FromDate { get; init; }
    public DateTime EndDate { get; init; }
}
public enum ResponseType
{
    MqttResponse,
    RestApiResponse
}
public enum ActionType
{
    LogRequest,
    PatchRequest,
    ProcessRequest,
    TpmConfiguration,
    TpmSealStorage,
    TpmNvStorage
}

public enum LogType
{
    SysLog,
    AppLog ,
    NetLog,
    ServiceLog,
    EventLog
}

public enum  LogLevel
{
    Info,
    Debug,
    Error,
    Warning,
    Fatal
}

public enum ActionValues
{
    SysLog,
    AppLog ,
    NetLog,
    ServiceLog,
    EventLog
}


