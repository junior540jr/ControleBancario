using ControleBancario;
using System;

namespace ControleBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("José", "123.456.789-00");
            Cliente cliente2 = new Cliente("Maria", "987.654.321-00");
            Cliente cliente3 = new Cliente("Pedro", "111.222.333-44");

            ContaCorrente contaCorrente = new ContaCorrente(cliente1);
            ContaEspecial contaEspecial = new ContaEspecial(cliente2, 1000);
            ContaCaixinha contaCaixinha = new ContaCaixinha(cliente3); 

            contaCorrente.Depositar(500);
            contaEspecial.Depositar(300);
            contaCaixinha.Depositar(50); 
            
            Console.WriteLine("=== SALDOS INICIAIS ===");
            Console.WriteLine($"Conta Corrente ({contaCorrente.Titular.Nome}): R$ {contaCorrente.Saldo:F2}");
            Console.WriteLine($"Conta Especial ({contaEspecial.Titular.Nome}): R$ {contaEspecial.Saldo:F2}");
            Console.WriteLine($"Conta Caixinha ({contaCaixinha.Titular.Nome}): R$ {contaCaixinha.Saldo:F2}");

            contaCorrente.Sacar(200);
            contaEspecial.Sacar(1000); 
            contaCaixinha.Sacar(20);   

            Console.WriteLine("\n=== APÓS SAQUES ===");
            Console.WriteLine($"Conta Corrente: R$ {contaCorrente.Saldo:F2}");
            Console.WriteLine($"Conta Especial: R$ {contaEspecial.Saldo:F2}");
            Console.WriteLine($"Conta Caixinha: R$ {contaCaixinha.Saldo:F2}");

            contaCorrente.Transferir(contaEspecial, 100);

            Console.WriteLine("\n=== APÓS TRANSFERÊNCIA ===");
            Console.WriteLine($"Conta Corrente: R$ {contaCorrente.Saldo:F2}");
            Console.WriteLine($"Conta Especial: R$ {contaEspecial.Saldo:F2}");
            Console.WriteLine($"Conta Caixinha: R$ {contaCaixinha.Saldo:F2}");

            Console.ReadLine();
        }
    }
}