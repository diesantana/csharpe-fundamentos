using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetosExercicios6
{
    internal class ContaBancaria
    {
        public int NumeroDaConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }
        public ContaBancaria() { }
        public ContaBancaria(int numeroDaConta, string nome)
        {
            NumeroDaConta = numeroDaConta;
            NomeTitular = nome;
        }

        public ContaBancaria(int numeroDaConta, string nome,double depositoInicial) :this (numeroDaConta, nome)
        {
            Saldo = depositoInicial;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= (valor + 5.0);
        }

        public override string ToString()
        {
            return "Conta " + NumeroDaConta +
                    ", Titular: " + NomeTitular + ", Saldo: $ " + 
                    Saldo.ToString("F2" , CultureInfo.InvariantCulture);
        }


    }
}
