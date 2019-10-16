using System;
using EscolaDeRock.Interface;
namespace EscolaDeRock.Models
{
    public class Baixo :  InstrumentoMusical, IPercursao, IHarmonia
    {
        public bool ManterRitmo()
        {
            Console.WriteLine("Mantendo o ritmo do Baixo.");
            return true;
        }

        public bool TocarAcordes()
        {
            Console.WriteLine("Tocando acordes do Baixo.");
            return true;
        }
    }
}