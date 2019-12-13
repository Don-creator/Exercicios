using System;
using RoletopMVC.Enums;

namespace RoletopMVC.Models
{
    public class Aluguel
    {
            public ulong Id {get;set;}
            public Cliente Cliente {get;set;}
            public ulong Status {get;set;}
            public DateTime DataDoAluguel {get;set;}
            public double PrecoTotal {get;set;}
        public Aluguel ()
        {
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (uint) StatusAluguel.PENDENTE;
        }
        
        }
    }