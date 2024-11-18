using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaPoupança : Conta
    {
        public double TaxaDeJuros { get; set; }

        public ContaPoupança(string Titular, double Saldo, double taxa)
            : base(Titular, Saldo)
        {
            TaxaDeJuros = taxa;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular:{Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Tipo de conta:Conta Poupança");

        }
        public void Depositar(double valor)
        {
            double resultado = valor + Saldo;

            TaxaDeJuros = 0.5;

            if (Saldo > 10)
            {
                double resultadoFinal = resultado + TaxaDeJuros;
                Console.WriteLine($"O valor é de {resultadoFinal}");
            }

        }

        public bool Sacar(double valor)
        {
            if (Saldo < 0 || Saldo < valor)
            {
                Console.WriteLine("Impossível sacar esse valor.");
                return false;
            }
            else
            {
                double resultado = Saldo - valor;
                return true;

            }

        }

    }
}
