using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
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

        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"cliente_nome = {cliente.Nome}; cliente_Endereco = {cliente.Endereco}; cliente_telefone = {cliente.Telefone}; cliente_email = {cliente.Email}; data_nascimento = {cliente.DataNascimento}";
        }
    } 
}