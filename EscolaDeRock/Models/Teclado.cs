using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models {
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia {
        public bool TocarAcordes () {
            Console.WriteLine ("Tocando acordes no Teclado");
            return true;
        }

        public bool TocarSolo () {
            Console.WriteLine ("Tocando solo no Teclado");
            return true;
        }
    }
}