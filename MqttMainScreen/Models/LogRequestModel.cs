namespace MqttMainScreen.Models;

public class LogRequestModel
{
   
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
    Tpmsetup,
    Tpmclr,
    Tpmcngpass,
    Tpmseal,
    Tpmunseal,
    Tpmdelseal,
    Tpmaddkey,
    Tpmdelkey,
    Tpmgetkey,
}

public enum ActionValues
{
    SysLog,
    AppLog ,
    NetLog,
    ServiceLog,
    EventLog
}


