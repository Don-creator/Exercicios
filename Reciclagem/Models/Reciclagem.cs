using System;

namespace Reciclagem.Models
{
    public class Reciclagem
    {
        string[] Cores = {"Amarelo", "Azul", "Cinza", "Preto", "Verde", "Vermelho"};

        public string ColetaSeletiva() {
            int Cores = new Random() .Next (Cores.Length - 1);
            return Cores = Cores[Cores];
        }
    }
}