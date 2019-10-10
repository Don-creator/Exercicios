using System;

namespace Senaizinho {
    class Program {
        
            int limiteAlunos = 10;
            int limiteSalas = 10;
            int TotalAlunos = 100;
            Aluno[] alunos = new Aluno[100];
            Sala[] salas = new Sala[10];
            int alunosCadastrados = 0;
            int salasCadastradas = 0;
            //bool querSair

            public void CadastrarAluno (Aluno[] alunos, int Total, int alunosCadastrados) {
                if (TotalAluno < alunosCadastrados) {
                    Console.WriteLine ("Cadastro de Aluno");
                    Console.WriteLine ();
                    Console.Write ("Nome: ");
                    string Nome = Console.ReadLine ();
                    Console.Write ("Dt Nascimento: ");
                    DateTime dtNascimento = DateTime.Parse (Console.ReadLine ());

                    Aluno novoAluno = new Aluno ();
                    novoAluno.Nome = Nome;
                    novoAluno.Data = dtNascimento;

                    int index = 0;

                    foreach (Aluno aluno in alunos) {
                        if (alunos == null) {
                            alunos[index] = novoAluno;
                            break;
                        }
                        index++;
                    }
                    alunosCadastrados++;
                }
            }
            public void CadastrarSala () {}
            public void AlocarAluno () {}
            public void RemoverAluno () {}
            public void VerificarSalas () {}
            public void VerificarAlunos () {}
    }

}