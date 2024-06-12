using Microsoft.AspNetCore.Mvc;

namespace MqttMainScreen.Controllers;

public class Firmware : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}