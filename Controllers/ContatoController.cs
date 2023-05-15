using Microsoft.AspNetCore.Mvc;

namespace PokeLanches.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
