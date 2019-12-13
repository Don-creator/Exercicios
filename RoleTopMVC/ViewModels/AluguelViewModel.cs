using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class AluguelViewModel : BaseViewModel 
    {
        public List<Aluguel> aluguel {get;set;}
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public AluguelViewModel()
        {
            this.Cliente = new Cliente();
            this.aluguel = new List<Aluguel>();
            this.NomeCliente = "Jovem";
        }
    }
}