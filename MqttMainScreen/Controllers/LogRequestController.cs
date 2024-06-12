using Microsoft.AspNetCore.Mvc;

namespace MqttMainScreen.Controllers;

public class LogRequestController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}