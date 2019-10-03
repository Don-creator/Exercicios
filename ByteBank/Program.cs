using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ByteBank - Cadastor do Cliente");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("CPF: ");
            string CPF = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();

            bool TrocouSenha = false;

            Cliente cliente1 = new Cliente(Nome, CPF, Email);

            do
            {
                Console.Write("Senha: ");
                string Senha = Console.ReadLine();
                TrocouSenha = cliente1.TrocaSenha(Senha);
                if (TrocouSenha){
                    Console.WriteLine("Senha alterada com sucesso");
                }
                else
                {
                    Console.WriteLine("Senha Invalida");
                }
            } while (!TrocouSenha);
        }
    }
}



