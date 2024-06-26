using Microsoft.AspNetCore.Mvc;
using MqttMainScreen.Models;

namespace MqttMainScreen.Controllers;

public class LogRequestController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Submit(LogRequestDto logRequestDto)
    {
        if (ModelState.IsValid)
        {
            // Handle the valid form submission
            // For example, you can save the data to a database, etc.
        }

        // If we got this far, something failed, redisplay form
        return View("Index", logRequestDto);
    }
}