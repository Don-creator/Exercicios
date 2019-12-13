using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            return View(new BaseViewModel(){
                NomeView = "Home",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            
            
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
