using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class ClienteViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;}
        public string NomeCliente {get;set;}

        public ClienteViewModel()
        {
            this.Cliente = new Cliente();
            this.NomeCliente = "Jovem";
        }
    }
}