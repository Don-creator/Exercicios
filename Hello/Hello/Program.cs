using System;
namespace notas
{
   class Program
   {
       static void Main(string[] args)
       {
            int nota1 = 0;
           int nota2 = 0;
            int nota3 = 0;
             int nota4 = 0;
             string media;
       Console.WriteLine("digite a nota1:");
       nota1 = int.Parse(Console.ReadLine());
       Console.WriteLine("digite a nota2:");
       nota2 = int.Parse(Console.ReadLine());
       Console.WriteLine("digite a nota3:");
       nota3 = int.Parse(Console.ReadLine());
       Console.WriteLine("digite a nota4:");
       nota4 = int.Parse(Console.ReadLine());
       media= Console.ReadLine();
       
       Console.WriteLine($"{(nota1 + nota2 + nota3 + nota4) / 4 } ");
       }
   }
}