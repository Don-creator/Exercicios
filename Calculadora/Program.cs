using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1° numero:");
            num1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Digite o 2° numero:");
            num2 = int.Parse (Console.ReadLine());
            Console.WriteLine("Digite o Operador:");
            oper = Console.ReadLine();

            if(oper=="+"){
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            if(oper=="-"){
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            if(oper=="*"){
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            if(oper=="/"){
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            if(oper=="%"){
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
            }
            else
            Console.WriteLine("operação invalida");
           
        
        }
    }
}
