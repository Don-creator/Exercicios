using System;
using EscolaDeRock.Interface;

namespace EscolaDeRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo(){
            Console.WriteLine("Mantendo o ritmo na Bateria.");
            return true;
        }
    }
}