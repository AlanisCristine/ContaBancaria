﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ContaBancaria.Entidade
{
    public class Conta : IConta
    {
        public Conta(int id, string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
            Id = id;
        }
        public Conta()
        {

        }
        public int Id { get; set; }
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public override string ToString()
        {
            return $"Titular: {Titular}, Saldo: {Saldo}";
        }

        public void Depositar(decimal valor)
        {
            Console.WriteLine("Qual foi o valor depositado?");
            decimal deposito = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"R${deposito} depositado com sucesso");

        }

     

        public virtual string ExibirInformacoes()
        {
            string MensagemExibirDetalhes = $"Titular:{Titular}" +
            $"\n Saldo: {Saldo}";
           

            return MensagemExibirDetalhes;
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

        public void Transferir(decimal valor, IConta contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar((decimal)valor);
        }

        
    }
}
