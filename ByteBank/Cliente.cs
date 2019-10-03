using System;

namespace ByteBank
{
    public class Cliente
    {
        public string CPF;
        public string Nome;
        public string Email;
        public string Senha;

        public Cliente(string Nome, string CPF, string Email)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Email = Email;
        }

        public bool TrocaSenha(string Senha){
            if ((Senha.Length > 6 ) && (Senha.Length < 16)){
                this.Senha = Senha;
                return true;
            }else {
                return false;
            }
            }
        }
    }

