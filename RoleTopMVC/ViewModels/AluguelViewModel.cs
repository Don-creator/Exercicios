using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class AluguelViewModel : BaseViewModel
    {
        public List<Festa> Festas {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public AluguelViewModel()
        {
            this.Festas = new List<Festa>();
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}