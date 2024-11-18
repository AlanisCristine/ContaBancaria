using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    public class ContaCorrente : Conta
    {
        public double LimiteDeCredito { get; set; }

        public ContaCorrente(string Titular, double Saldo, double LimiteDecredito)
            : base(Titular, Saldo)
        {
            LimiteDeCredito = LimiteDecredito;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular:{Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Tipo de conta:Conta Corrente");

        }


        public void Depositar(double valor)
        {
            double resultado = valor + Saldo;
            Console.WriteLine($"O resultado do depósito com o saldo é:{resultado}");

        }
        public bool Sacar(double valor)
        {
            if(Saldo < 0 || Saldo < valor)
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
