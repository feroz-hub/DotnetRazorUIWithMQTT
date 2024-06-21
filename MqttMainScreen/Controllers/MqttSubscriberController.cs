using Microsoft.AspNetCore.Mvc;

namespace MqttMainScreen.Controllers;

public class MqttSubscriberController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}