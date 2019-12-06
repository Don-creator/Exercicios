using System.Collections.Generic;
using RoletopMVC.Models;

namespace RoletopMVC.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Aluguel> Alugueis { get; set; }
        public uint alugueisAprovados { get; set; }
        public uint alugueisReprovados { get; set; }
        public uint alugueisPendentes { get; set; }

        public DashboardViewModel() 
        {
        this.Alugueis = new List<Aluguel>();
        }
    }
}