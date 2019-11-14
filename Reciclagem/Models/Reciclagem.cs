using System;

namespace Reciclagem.Models
{
    public class Reciclagem
    {
        string[] Cores = {"Amarelo", "Azul", "Cinza", "Preto", "Verde", "Vermelho"};
        string[] Lixos = {"Garrafa","GarrafaPet","GuardaChuva","Papelao","PoteManteiga"};

        public string ColetaSeletiva() {
            int Cores = new Random() .Next (Lixos.Length - 1);
            return Cores = Lixos[];

            
        }
    }
}