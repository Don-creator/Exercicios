using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank2.Models {
    public class ContaEspecial : ContaBancaria {
        public double Limite;
        public ContaEspecial (int Agencia, int NumeroConta, string Titular) : base (Agencia, NumeroConta, Titular) {
            Limite = 0.0;
        }
        public bool SetLimite (double valor) {
            if (Valor >= 0) {
                Limite = valor;
                return true;
            }
            return false;
        }
        public override bool Saque (double Valor) {
            if (Valor >= 0) {
                if (valor <= Saldo + Limite) {
                    Saldo -= Valor;
                    return true;
                }
            }
            return false;
        }
    }
}