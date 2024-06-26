using Microsoft.AspNetCore.Mvc;

namespace MqttMainScreen.Controllers;

public class ClientController(IMqttClientRepository mqttClientRepository) : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var clients=await mqttClientRepository.GetAllClientsAsync();
        return View(clients);
    }

    public IActionResult Register()
    {
        return View();
    }
}