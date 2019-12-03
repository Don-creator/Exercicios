using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class AluguelController : AbstractController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}