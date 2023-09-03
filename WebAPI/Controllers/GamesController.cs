using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class GamesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
