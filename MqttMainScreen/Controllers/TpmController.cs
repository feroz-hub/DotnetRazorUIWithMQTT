using Microsoft.AspNetCore.Mvc;

namespace MqttMainScreen.Controllers;

public class TpmController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult TpmSetup()
    {
        return View();
    }

    public IActionResult TpmClear()
    {
        return View();
    }

    public IActionResult ChangePassword()
    {
        return View();
    }

    public IActionResult SealHash()
    {
        return View();
    }

    public IActionResult UnSealHash()
    {
        return View();
    }

    public IActionResult DeleteHash()
    {
        return View();
    }

    public IActionResult StoreEncryptionKey()
    {
       return View();
    }

    public IActionResult GetEncryptionKey()
    {
        return View();
    }

    public IActionResult DeleteEncryptionKey()
    {
        return View();
    }
    
}