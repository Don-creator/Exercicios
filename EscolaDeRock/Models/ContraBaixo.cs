using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models {
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia {
        public bool ManterRitmo () {
            Console.WriteLine ("Mantendo o ritmo do Contrabaixo");
            return true;
        }

        public bool TocarAcordes () {
            Console.WriteLine ("Tocando acordes do Contrabaixo.");
            return true;
        }
    }
}