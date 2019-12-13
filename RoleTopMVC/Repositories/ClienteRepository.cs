using System;
using System.IO;
using RoletopMVC.Models;

namespace RoletopMVC.Repositories
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

            foreach (var linha in linhas)
            {
                if(ExtrairValorDoCampo("cliente_email", linha).Equals(Email))
                {
                    Cliente c = new Cliente();
                    c.TipoUsuario = uint.Parse(ExtrairValorDoCampo("tipo_usuario", linha));
                    c.Nome = ExtrairValorDoCampo("cliente_nome",linha);
                    c.Email = ExtrairValorDoCampo("cliente_email",linha); 
                    c.Senha = ExtrairValorDoCampo("cliente_senha",linha);
                    c.Endereco = ExtrairValorDoCampo("cliente_endereco",linha);
                    c.Telefone = ExtrairValorDoCampo("cliente_telefone",linha);
                    c.CPF = ExtrairValorDoCampo("cliente_cpf", linha);
                    
                    return c;
                }
            }
            return null;
        }


    private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"tipo_usuario={cliente.TipoUsuario};cliente_nome={cliente.Nome};cliente_email={cliente.Email};cliente_senha={cliente.Senha};cliente_endereco={cliente.Endereco};cliente_telefone={cliente.Telefone};cliente_cpf={cliente.CPF}";
        }
    }
}