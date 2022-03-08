using Microsoft.AspNetCore.Mvc;

namespace TaskClient.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
