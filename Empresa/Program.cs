using System;

namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarionovo;
            Console.Write("digite o salario:");
            salario = double.Parse(Console.ReadLine());

            if(salario<500.00){
                salarionovo = salario+(salario* 0.30);
                Console.WriteLine("o salario novo é " + salarionovo);
            }

        else if(salario==500.00){
                salarionovo = salario+(salario* 0);
                Console.WriteLine("o salario não obteve aumento " + salarionovo);
            }  
        }
    }
}
