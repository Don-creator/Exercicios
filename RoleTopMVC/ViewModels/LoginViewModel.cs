using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;}

        public LoginViewModel()
        {
            this.Cliente = new Cliente();
        }
    }
}