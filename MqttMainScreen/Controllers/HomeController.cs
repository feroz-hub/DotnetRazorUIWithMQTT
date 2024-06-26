using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MqttMainScreen.Models;

namespace MqttMainScreen.Controllers;

public class HomeController(IMqttClientRepository mqttClientRepository) : Controller
{
    public async Task<IActionResult> Index()
    {
        var clients=await mqttClientRepository.GetAllClientsAsync();
        return View(clients);
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