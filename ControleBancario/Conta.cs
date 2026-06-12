using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario
{
    public class Conta
    {
        protected double saldo;
        protected Cliente titular;

        public double Saldo
        {
            get { return saldo; }
        }

        public Cliente Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public Conta(Cliente titular)
        {
            this.titular = titular;
            this.saldo = 0;
        }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
            }
        }

        public virtual bool Sacar(double valor)
        {
            if (valor > 0 && saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public bool Transferir(Conta destino, double valor)
        {
            if (valor > 0 && Sacar(valor))
            {
                destino.Depositar(valor);
                return true;
            }
            return false;
        }
    }
}
