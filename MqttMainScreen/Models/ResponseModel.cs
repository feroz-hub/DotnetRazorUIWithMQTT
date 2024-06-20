namespace MqttMainScreen.Models;

public class ResponseModel
{
    public ActionType ActionType { get; set; }
    public string? RequestId { get; set; }
    public string? Message { get; set; }
    public int Status { get; set; }
    public string? Result { get; set; }
}