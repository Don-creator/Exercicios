using System;

namespace Administrador
{
    class Program
    {
        static void Main(string[] args)
        {
            string admLogin = "admin";
            string admPass; = "admin";

            Console.Write(" Entre com o Usuario: ");
            string login = Console.ReadLine();

            Console.Write("Entre com a senha: ");
           string passwd = Console.ReadLine();

           if ((login == admLogin) && passwd == admPasswd ){
               Console.WriteLine("Bem Vindo Admin.");
           } else{
               Console.WriteLine("Olá usuario.");
           }

            
          
        }
    }
}
