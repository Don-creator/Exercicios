
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Controllers;
using RoletopMVC.Enums;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;
using RoleTopMVC.Repositories;
using System;
namespace McBonaldsMVC.Controllers
{
    public class AluguelController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        AluguelRepository aluguelRepository = new AluguelRepository();
        public IActionResult Index()
        {
            
            AluguelViewModel avm = new AluguelViewModel();
            
            var emailCliente = ObterUsuarioSession();
            if(!string.IsNullOrEmpty(emailCliente))
            {
                avm.Cliente = clienteRepository.ObterPor(emailCliente);
            }
            var nomeUsuario = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuario))
            {
                avm.NomeCliente = nomeUsuario;
            }
                avm.NomeView = "Aluguel";
                avm.UsuarioEmail = emailCliente;
                avm.UsuarioNome = nomeUsuario;
                return View(avm);
        }
        public IActionResult Registrar(IFormCollection form)
        {
            ViewData["Action"]= "Aluguel";
            Aluguel aluguel = new Aluguel();
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.CPF = form["cpf"];
            aluguel.DataDoAluguel = DateTime.Now;
            aluguel.Cliente = cliente; 
            if(aluguelRepository.Inserir(aluguel))
            {
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "aluguel",
                    Mensagem = $"{cliente.Nome} pedido realizado com sucesso!"
                });
            } else {
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "aluguel",
                    Mensagem = $"{cliente.Nome} pedido não realizado!"
                });
            }
        }
    
        public IActionResult Aprovar (ulong id)
        {
            var aluguel = aluguelRepository.ObterPor(id);
            aluguel.Status = (uint) StatusAluguel.APROVADO;

            if(aluguelRepository.Atualizar(aluguel))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possivel aprovar este pedido"){
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Reprovar (ulong id)
        {
            var aluguel = aluguelRepository.ObterPor(id);
            aluguel.Status = (uint) StatusAluguel.REPROVADO;

            if(aluguelRepository.Atualizar(aluguel))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possivel reprovar este aluguel"){
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}