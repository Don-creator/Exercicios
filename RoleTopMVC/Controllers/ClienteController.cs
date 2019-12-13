using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Controllers;
using RoletopMVC.Enums;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;
using RoleTopMVC.Repositories;

namespace McBonaldsMVC.Controllers
{
    public class ClienteController : AbstractController
    {
        private AluguelRepository aluguelRepository = new AluguelRepository();
        private ClienteRepository clienteRepository = new ClienteRepository();

        
        [HttpGet]
        public IActionResult Login()
        {
            ViewData["Action"] = "Login";
            return View(new BaseViewModel()
            {
                NomeView = "Login", 
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            ClienteRepository clienteRepository = new ClienteRepository();
            try
            {
                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente != null)
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch(cliente.TipoUsuario){
                            case (uint) TiposUsuario.CLIENTE:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                                
                                return RedirectToAction("Historico","Cliente");
                            
                            default:
                                HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                                HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                                HttpContext.Session.SetString(SESSION_CLIENTE_TIPO, cliente.TipoUsuario.ToString());
                                
                                return RedirectToAction("Dashboard","Administrador");
                            
                        }
                    }
                    else 
                    {
                        return View("Erro", new RespostaViewModel("Senha incorreta"));
                    }

                } 
                else
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não encontrado"));
                }

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro");
            }
        }
    
        public IActionResult Historico ()
        {
            var emailCliente = HttpContext.Session.GetString(SESSION_CLIENTE_EMAIL);
            var alugueisCliente = aluguelRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
                Alugueis = alugueisCliente,
                NomeView = "Historico",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}