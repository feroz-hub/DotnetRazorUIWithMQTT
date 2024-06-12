using Microsoft.AspNetCore.Mvc;

namespace MqttMainScreen.Controllers;

public class TpmController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}