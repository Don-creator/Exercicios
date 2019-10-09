using System;

namespace Senaizinho {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();

            Console.WriteLine ("Cadastro de Alunos");

            Console.WriteLine ("Digite seu Nome: ");
            string Nome = Console.ReadLine ();
            Console.WriteLine ("Digite a data de nascimento: ");
            DateTime Data = DateTime.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o curso: ");
            string Curso = Console.ReadLine ();
            Console.WriteLine ("Digite o numero da sala: ");
            int numeroSala = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Alocar Aluno.");
            Console.WriteLine ("Qual o Nome do Aluno: ");
            Console.ReadLine ();
            Console.WriteLine ("Qual sala ele será registrado: ");
            Console.ReadLine ();

            Console.WriteLine ("Remover Aluno.");

            Console.WriteLine ("Qual Nome do Aluno: ");
            Console.ReadLine ();
            Console.WriteLine ("Qual sala: ");
            Console.ReadLine ();

            Console.WriteLine ("Numero da Sala.");
            Console.ReadLine ();
            Console.WriteLine ("Quantidade de alunos registrados na sala: ");
            Console.ReadLine ();
            Console.WriteLine ("Nomes de todos os alunos da sala: ");
            Console.ReadLine ();

        }

    }
}