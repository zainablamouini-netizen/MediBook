using Microsoft.AspNetCore.Mvc;

namespace MediBook.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
