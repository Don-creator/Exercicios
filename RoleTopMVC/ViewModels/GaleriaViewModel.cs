using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class GaleriaViewModel
    {
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public GaleriaViewModel()
        {
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}
