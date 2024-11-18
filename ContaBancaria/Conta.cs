using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ContaBancaria
{
    public class Conta: IConta
    {
        public Conta(string titular, double saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public string Titular { get; set; }
        public double Saldo { get; set; }
        public override string ToString()
        {
            return $"Titular: {Titular}, Saldo: {Saldo}";
        }

        public void Depositar(double valor)
        {
            Console.WriteLine("Qual foi o valor depositado?");
            double deposito = double.Parse(Console.ReadLine());
            Console.WriteLine($"R${deposito} depositado com sucesso");
            
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular:{Titular}");
            Console.WriteLine($"Saldo: {Saldo}");
            Console.WriteLine($"Tipo de conta:");
           
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

        public void Transferir(double valor, IConta contaDestino)
        {
          this.Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
