using Microsoft.AspNetCore.Mvc;

namespace RoletopMVC.Controllers
{
    public class LoginController : AbstractController
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}