using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}