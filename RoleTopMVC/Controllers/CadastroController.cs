using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Controllers;
using RoletopMVC.Enums;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {

            Cliente cliente = new Cliente();

            return View(new BaseViewModel()
            {
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Cliente cliente = new Cliente(form["nome"], form["email"], form["senha"], form["endereco"], form["telefone"], form["cpf"]);
            ViewData["Action"] = "Cadastro";
            try
            {
                cliente.TipoUsuario = (uint) TiposUsuario.CLIENTE;
                clienteRepository.Inserir(cliente);
                
                return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
            } 
            catch(Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Cadastro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        
    }
}