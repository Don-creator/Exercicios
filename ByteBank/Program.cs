using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {
            #region Cadastro de Cliente. 

            Console.WriteLine ("ByteBank - Cadastor do Cliente");
            Console.Write ("Nome: ");
            string Nome = Console.ReadLine ();
            Console.Write ("CPF: ");
            string CPF = Console.ReadLine ();
            Console.Write ("Email: ");
            string Email = Console.ReadLine ();

            Cliente cliente1 = new Cliente (Nome, CPF, Email);
            Console.WriteLine (cliente1.Senha);

            bool TrocouSenha = false;

            do {
                Console.Write ("Senha: ");
                string Senha = Console.ReadLine ();
                TrocouSenha = cliente1.TrocaSenha (Senha);
                if (TrocouSenha) {
                    Console.WriteLine ("Senha alterada com sucesso");
                } else {
                    Console.WriteLine ("Senha Invalida");
                }
            } while (!TrocouSenha);
            Console.WriteLine ();

            Console.WriteLine ("ByteBank - Cadastro da Conta");
            Console.Write ("Entre com a Agencia: ");
            int Agencia = int.Parse (Console.ReadLine ());
            Console.Write ("Entre com a Conta: ");
            int Conta = int.Parse (Console.ReadLine ());

            ContaCorrente contaCorrente1 = new ContaCorrente (Agencia, Conta, cliente1);
            double Saldo;
            do {
                Console.Write ("Entre com o Saldo: ");
                Saldo = double.Parse (Console.ReadLine ());
                if (Saldo >= 0) {
                    contaCorrente1.Saldo = Saldo;
                } else {
                    Console.WriteLine ("Valor do Saldo deve ser positivo.");
                }
            } while (Saldo < 0);
            Console.WriteLine ();
            #endregion

            Cliente cliente2 = new Cliente ("Cesar", "123.123.123.12", "1@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente ("123", "312", cliente2);

            #region Deposito.
            Cliente Usuario = contaCorrente1.Titular;
            Console.WriteLine ("ByteBank - Deposito em Conta");
            Console.WriteLine ($"Bem Vindo - {Usuario.Nome}");
            Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente2.Numero}");
            Console.WriteLine ($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine ();
            Console.Write ("Digite o Valor do Deposito: ");
            double Valor = double.Parse (Console.ReadLine ());
            contaCorrente1.Deposito (Valor);
            Console.WriteLine ();
            Console.WriteLine ($"Novo Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine ();
            #endregion

            #region Saque.
            Console.WriteLine ("ByteBank - Saque");
            Console.WriteLine ($"Bem Vindo - {Usuario.Nome}");
            Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente2.Numero}");
            Console.WriteLine ($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine ();
            Console.Write ("Digite o Valor do Deposito: ");
            double valor = double.Parse (Console.ReadLine ());
            contaCorrente1.Deposito (Valor);
            Console.WriteLine ();
            Console.WriteLine ($"Novo Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine ();

            #endregion

            #region Transferencia.
            Console.WriteLine ("ByteBank - Transferencia");
            Console.WriteLine ($"Bem Vindo - {Usuario.Nome}");
            Console.WriteLine ($"Agencia {contaCorrente1.Agencia} Conta: {contaCorrente2.Numero}");
            Console.WriteLine ($"Saldo: {contaCorrente1.Saldo}");
            Console.WriteLine ();
            Console.Write ("Digite o Valor do Transferencia: ");
            Valor = double.Parse (Console.ReadLine ());
            if (contaCorrente1.Transferencia (contaCorrente2, Valor)) {
                Console.WriteLine ("Transferencia Efetuada");
            } else {
                Console.WriteLine ("Não foi possivel realizar a operação");
            }

        }
    }