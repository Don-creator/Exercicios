namespace RoletopMVC.Models
{
    public class Festa : Salao
    {
        public Festa()
        {

        }

        public Festa( string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}