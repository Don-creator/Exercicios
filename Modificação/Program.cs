using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2,  nota3, nota4, media; 

          Console.WriteLine("Digite a nota1:");
          nota1 = double.Parse(Console.ReadLine());
          Console.WriteLine("Digite a nota2:");
          nota2 = double.Parse(Console.ReadLine());
          Console.WriteLine("Digite a nota3:");
          nota3 = double.Parse(Console.ReadLine());
          Console.WriteLine("Digite a nota4:");
          nota4 = double.Parse (Console.ReadLine());

          media = (nota1 + nota2 + nota3 + nota4 ) / 4;

         Console.WriteLine("Sua média é " + media );

         if(media>=7)
         Console.WriteLine("aprovado");
         if(media<=7)
         Console.WriteLine("reprovado");
        
        }
    }
}
