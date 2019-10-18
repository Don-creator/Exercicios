using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public double Limite;

        public ContaCorrente(int Agencia, int NumeroConta, string Titular) : base(Agencia, NumeroConta, Titular)
        {
            Limite = 0.0;
        }

        public bool SetLimite(double Valor)
        {
            if (Valor >= 0)
            {
                this.Limite = Valor;
                return true;
            }
            return false;
        }
        public override bool Saque(double Valor)
        {
            if (Valor >= 0)
            {
                if(Valor <= Saldo + Limite)
                {
                    Saldo -= Valor;
                    return true;
                }
            }
            return false;
        }
    }
}