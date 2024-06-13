namespace MqttMainScreen.Models;

public class ProcessRequestModel
{
    public string TargetId { get; set; }
    public string SourceId { get; set; }
    public ActionType ActionType { get; set; }
    public DateTime RequestDate { get; set; }
    public bool IsAckRequired { get; set; }
    public string ResponseType { get; set; }
    public InputParams InputParams { get; set; }
}
public class InputParams
{
    public string ProcessNames { get; set; }
}