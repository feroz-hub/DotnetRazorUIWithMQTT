namespace MqttMainScreen.Models;

public class LogRequestModel

{
   public Guid RequestId { get; set; }
    public string TargetId { get; init; }
    public string SourceId { get; init; }
    public ActionType ActionType { get; init; }
    public DateTime RequestDate { get; set; }
    public bool IsAckRequired { get; init; }
    public ActionValues ActionValues { get; init; }
    public ResponseType ResponseType { get; init; }
    public DateTime FromDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class MqttLogRequest
{
    public Guid RequestId { get; set; }
    public string TargetId { get; init; }
    public string SourceId { get; init; }
    public ActionType ActionType { get; init; }
    public DateTime RequestDate { get; set; }
    public bool IsAckRequired { get; init; }
    public LogRequestDto LogRequestDto { get; set; }
}
public class LogRequestDto
{
    public List<LogType>  LogTypes { get; init; }=default!;
    public List<LogLevel> LogLevels { get; init; }=default!;
    public DateTime FromDate { get; set; }
    public DateTime EndDate { get; set; }
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


