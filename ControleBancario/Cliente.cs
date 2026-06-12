using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}
