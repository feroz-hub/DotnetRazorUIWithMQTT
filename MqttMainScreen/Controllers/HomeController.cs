using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MqttMainScreen.Models;

namespace MqttMainScreen.Controllers;

public class HomeController(IMqttClientRepository mqttClientRepository) : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<IActionResult> RightSection()
    {
        var clients=await mqttClientRepository.GetAllClientsAsync();
        return PartialView("_RightSection", clients);
    }
}