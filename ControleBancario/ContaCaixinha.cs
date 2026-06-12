using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(Cliente titular, double saldoInicial = 10.00) : base(titular)
        {
            this.saldo = saldoInicial;
        }

        public override void Depositar(double valor)
        {
            if (valor < 1.00)
            {
                Console.WriteLine("Erro: Não são permitidos depósitos inferiores a R$ 1,00 na Conta Caixinha.");
                return;
            }

            saldo += valor + 1.00;
        }

        public override bool Sacar(double valor)
        {
            double valorComTaxa = valor + 5.00;

            if (valor > 0 && saldo >= valorComTaxa)
            {
                saldo -= valorComTaxa;
                return true;
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente na Caixinha para o saque de R$ {valor:F2} + Taxa de R$ 5,00.");
                return false;
            }
        }
    }
}
