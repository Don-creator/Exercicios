using System;

namespace Aluno
{
    public class Aluno{
        //Propriedades
        public string Nome{get; set; };
        public string Curso{get; set; };
        public string Cpf{get; set; };
        public int[] Notas;

        //construtor
        public Aluno(string Nome, string Cpf){
            this.Nome = Nome;
            this.Cpf = Cpf;
        }
        public Aluno(string Nome, string Cpf, string Curso){
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Curso = Curso;
        }
        //Metodos de Acesso
        public int[] getNotas(){return notas;}

        public void setNotas(int bi, int nota){
            if((i < 0) || (i > 3)){
                //Condição de Erro;
                throw new ArgumentOutOfRangeException($"{nameof(value)} must 1 and 4,");
            } else if (nota < 0 || )
        }
    }

}
