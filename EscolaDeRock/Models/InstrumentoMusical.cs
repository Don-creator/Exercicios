using System;
namespace EscolaDeRock.Models {
        public class InstrumentoMusical {

            string[] Notas = { "Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si" };

            public string TocarMusica () {
                int Nota = new Random () .Next (Notas.Length - 1);
                return Notas[Nota];
            }
        }
    }

