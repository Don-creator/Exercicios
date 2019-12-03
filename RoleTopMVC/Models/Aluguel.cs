using System;
using RoletopMVC.Enums;

namespace RoletopMVC.Models
{
    public class Aluguel
    {
        public Aluguel (ulong id, Cliente cliente, Festa festa, Salao salao, DateTime dataDoAluguel, double precoTotal, ulong status)
        {

            this.Id = id;
            this.Cliente = cliente;
                this.dataDoAluguel = dataDoAluguel;
                this.PrecoTotal = precoTotal;
                this.Status = status;
        }
            public ulong Id {get;set;}

            public Cliente Cliente {get;set;}

        public Festa festa {get; set;}
        public Salao salao {get;set;}

        public DateTime dataDoAluguel {get;set;}
        public double PrecoTotal {get;set;}

        public ulong Status {get;set;}

        public Aluguel()
        {
            this.Cliente = new Cliente();
            this.festa = new Festa();
            this.salao = new Salao();
            this.Id = 0;
            this.Status = (uint) StatusAluguel.PENDENTE;
        }
        }
    }