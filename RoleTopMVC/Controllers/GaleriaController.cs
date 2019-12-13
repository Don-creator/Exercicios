using Microsoft.AspNetCore.Mvc;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Controllers
{
    public class GaleriaController : AbstractController
    {
        public IActionResult Index()
        {

            GaleriaViewModel gvm = new GaleriaViewModel();

            return View(new BaseViewModel(){
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
    }
} 