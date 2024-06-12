using Microsoft.AspNetCore.Mvc;

namespace MqttMainScreen.Controllers;

public class DevicePerformanceController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}