using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Enums;
using RoletopMVC.ViewModels;
using RoleTopMVC.Repositories;

namespace RoletopMVC.Controllers
{
public class AdministradorController : AbstractController
    {
        AluguelRepository aluguelRepository = new AluguelRepository();
        public IActionResult Dashboard()
        {

            var ninguemLogado = string.IsNullOrEmpty(ObterUsuarioTipoSession());
            
            if (!ninguemLogado || (uint) TiposUsuario.ADMINISTRADOR == uint.Parse(ObterUsuarioTipoSession()))                                                                         
            {
                var alugueis = aluguelRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            foreach (var aluguel in alugueis)
            {
                switch(aluguel.Status)
                {
                    case (uint) StatusAluguel.APROVADO:
                        dashboardViewModel.alugueisAprovados++;
                    break;
                    case (uint) StatusAluguel.REPROVADO:
                        dashboardViewModel.alugueisReprovados++;
                    break;
                    default:
                    dashboardViewModel.alugueisPendentes++;
                    dashboardViewModel.Alugueis.Add(aluguel);
                    break;
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            return View(dashboardViewModel);
            }
            else
            {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Dashboard",
                    Mensagem= "Você não tem permissão para acessar o Dashboard"
                });
            }
        }
    }
}