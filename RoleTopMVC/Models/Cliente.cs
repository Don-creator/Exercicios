using System;

namespace RoletopMVC.Models
{
    public class Cliente
    {
        public uint TipoUsuario {get;set;}
        public string Nome {get;set;}
        public string Email {get;set;}
        public string Senha {get;set;}
        public string Endereco {get;set;}
        public string Telefone {get;set;}
        public string CPF {get;set;}

        public Cliente()
        {
            
        }

        public Cliente(string nome,string email, string senha,  string endereco, string telefone, string CPF)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.CPF = CPF;
            
        }
    }
}