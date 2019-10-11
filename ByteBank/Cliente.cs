using System;

namespace ByteBank
{
    public class Cliente
    {
        private string _CPF;
        private string _Nome;
        private string _Email;
        private string _Senha;

        public string Senha
        {
            get { return _Senha; }
        }

        public string CPF
        {
            get { return _CPF; }
            set { _CPF = value; }
        }

        public string Nome {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public string Email
        {
            get { return _Email ; }
            set { _Email = value; }
        }

        public Cliente(string Nome, string CPF, string Email)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Email = Email;
        }

        public bool TrocaSenha(string Senha){
            if ((Senha.Length > 6 ) && (Senha.Length < 16)){
                this._Senha = Senha;
                return true;
            }else {
                return false;
            }
            }
        }
    }

