using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models {
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia, IPercursao {
        public bool ManterRitmo () {
            Console.WriteLine ("Mantendo o ritmo do Violao");
            return true;
        }

        public bool TocarSolo () {
            Console.WriteLine ("Tocando solo do Violao");
            return true;
        }
        public bool TocarAcordes () {
            Console.WriteLine ("Tocando acordes de Violao.");
            return true;
        }
    }
}