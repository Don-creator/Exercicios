using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
namespace RoleTopMVC.Repositories
{
    public class AluguelRepository  : RepositoryBase{
        private const string PATH = "Database/Aluguel.csv";
        public AluguelRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Aluguel reserva) {
            var quantidadeAlugueis = File.ReadAllLines(PATH).Length;
            reserva.Id = (ulong) ++quantidadeAlugueis;
            var linha = new string[] { PrepararPedidoCSV (reserva) };
            File.AppendAllLines (PATH, linha);
            return true;
        }
        public List<Aluguel> ObterTodosPorCliente(string emailCliente)
        {
        List<Aluguel> aluguelCliente = new List<Aluguel>();
            var alugueis = ObterTodos();
            foreach (var aluguel in alugueis)
            {
                if(aluguel.Cliente.Email.Equals(emailCliente))
                {
                    aluguelCliente.Add(aluguel);
                }
            }
            return aluguelCliente;
        }
        public List<Aluguel> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Aluguel> reservas = new List<Aluguel>();
            foreach (var linha in linhas)
            {
                Aluguel aluguel = new Aluguel();
                aluguel.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                aluguel.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                aluguel.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                aluguel.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                aluguel.PrecoTotal = double.Parse(ExtrairValorDoCampo("preco_total", linha));
                aluguel.dataDoAluguel = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));
                reservas.Add(aluguel);
            }
            return reservas;
        }
        public Aluguel ObterPor(ulong id)
        {
            var alugueisTotais = ObterTodos();
            foreach (var reserva in alugueisTotais)
            {
                if(id.Equals(reserva.Id))
                {
                    return reserva;
                }
            }
            return null;
        }
        public bool Atualizar(Aluguel aluguel)
        {
            var alugueisTotais = File.ReadAllLines(PATH);
            var pedidoCSV =  PrepararPedidoCSV(aluguel);
            var linhaPedido = -1;
            var resultado = false;
            for (int i = 0; i < alugueisTotais.Length; i++)
            {
                var idConvertido =  ulong.Parse(ExtrairValorDoCampo("id", alugueisTotais[i]));
                if(aluguel.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }
            if(resultado)
            {
                alugueisTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines(PATH, alugueisTotais);
            }
            return resultado;
        }
        private string PrepararPedidoCSV (Aluguel aluguel) {
            Cliente c = aluguel.Cliente;
            return $"id={aluguel.Id};status_aluguel={aluguel.Status};cliente_nome={c.Nome};cliente_email={c.Email};data_aluguel={aluguel.dataDoAluguel};preco_total={aluguel.PrecoTotal}";
        }

        
    }
}