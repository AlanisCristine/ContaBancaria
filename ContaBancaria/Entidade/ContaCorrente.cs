using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidade
{
    [Table("ContaCorrente")]
    public class ContaPoupanca : Conta
    {
        public decimal LimiteDeCredito { get; set; }

        public ContaPoupanca(int Id, string Titular, decimal Saldo, decimal LimiteDecredito)
            : base(Id,Titular, Saldo)
        {
            LimiteDeCredito = LimiteDecredito;
        }

        public ContaPoupanca()
        {

        }

       
        public override string ExibirInformacoes()
        {
            string mensagemDetalhes = base.ExibirInformacoes();
            mensagemDetalhes +=
                 $"Titular:{Titular}" 
                  + $"\nSaldo: {Saldo}";

            return mensagemDetalhes;
        }


        public void Depositar(decimal valor)
        {
            decimal resultado = valor + Saldo;
            Console.WriteLine($"O resultado do depósito com o saldo é:{resultado}");

        }
        public bool Sacar(decimal valor)
        {
            if (Saldo < 0 || Saldo < valor)
            {
                Console.WriteLine("Impossível sacar esse valor.");
                return false;
            }
            else
            {
                decimal resultado = Saldo - valor;
                return true;

            }

        }
    }
}
