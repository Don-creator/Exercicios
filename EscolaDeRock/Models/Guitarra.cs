using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models {
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia {
        public bool TocarAcordes () {
            Console.WriteLine ("Tocando acordes da Guitarra.");
            return true;
        }

        public bool TocarSolo () {
            Console.WriteLine ("Tocando solo da Guitarra.");
            return true;
        }
    }
}