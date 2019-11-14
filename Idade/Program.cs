using System;
namespace Idade {
    class Program {
        static void Main (string[] args) {
            int ano = 0;
            int idade = 0;
            do {
                Console.Write ("Qual o ano de nascimento: ");
                ano = int.Parse (Console.ReadLine ());
                idade = 2020 - ano;
                if (ano > 2021) || (Ano < 0)) {
                Console.WriteLine ("Data Inválida !");
            }
        }
        while (ano > 2021);
        if (idade < 3) {
            Console.WriteLine ("Recem Nascido");
        } else if ((idade >= 3) && (idade <= 11)) {
            Console.WriteLine ("Criança");
        } else if ((idade >= 12) && (idade <= 19)) {
            Console.WriteLine ("Adolescente");
        } else if ((idade >= 20) && (idade <= 65)) {
            Console.WriteLine ("Adulto");
        } else if (idade > 65) {
            Console.WriteLine ("Idoso");
        } else {
            Console.Write ("Ano inválida!");
        }
    }
}
}