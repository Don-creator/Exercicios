using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository : RepositoryBase
    {
        private const string PATH = "Database/Cliente.csv";

        public ClienteRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public bool Inserir(Cliente cliente)
        {
            var linha = new string [] {PrepararRegistroCSV (cliente) };
            
            File.AppendAllLines(PATH, linha); //Acrescenta linhas a um arquivo e fecha o arquivo. Se o arquivo especificado não existir, esse método criará um arquivo,gravará as linhas especificadas no arquivo e fechará o arquivo.

            return true;
        }

        public Cliente ObterPor(string Email)
        {
            var linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if(!ExtrairValorDoCampo("email", item).Equals(Email))
                {
                    Cliente c = new Cliente();
                    c.Nome = ExtrairValorDoCampo("cliente_nome",item);
                    c.Email = ExtrairValorDoCampo("cliente_email",item);
                    c.DataNascimento = DateTime.Parse(ExtrairValorDoCampo("data_nascimento",item));
                    c.Endereco = ExtrairValorDoCampo("cliente_endereco",item);
                    c.Telefone = ExtrairValorDoCampo("cliente_telefone",item);
                    c.Senha = ExtrairValorDoCampo("cliente_senha",item);

                    return c;
                }
            }
            return null;
        }


        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"cliente_nome={cliente.Nome};cliente_senha{cliente.Senha};cliente_endereco={cliente.Endereco};cliente_telefone={cliente.Telefone};cliente_email={cliente.Email};data_nascimento={cliente.DataNascimento}";
        }
    } 
}