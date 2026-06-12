using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario
{
    public class ContaEspecial : Conta
    {
        public double Limite { get; set; }

        public ContaEspecial(Cliente titular, double limite) : base(titular)
        {
            Limite = limite;
        }

        public override bool Sacar(double valor)
        {
            if (valor > 0 && (saldo + Limite) >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
