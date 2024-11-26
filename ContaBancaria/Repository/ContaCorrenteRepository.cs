using ContaBancaria.Entidade;
using ContaBancaria.Entidade.Interfaces;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Repository
{
    public class ContaCorrenteRepository : IContaCorrente
    {
        private readonly string ConnectionString;

        public ContaCorrenteRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(ContaPoupanca carro)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<ContaPoupanca>(carro);
        }
        public void Remover(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaPoupanca carrinho = BuscarPorId(id);
            connection.Delete<ContaPoupanca>(carrinho);
        }
        public void Editar(ContaPoupanca carrinho)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Update<ContaPoupanca>(carrinho);
        }
        public List<ContaPoupanca> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<ContaPoupanca>().ToList();
        }
        public ContaPoupanca BuscarPorId(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.Get<ContaPoupanca>(id);
        }
        public string ExibirInformacoes(int id)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            ContaPoupanca carrinho = BuscarPorId(id);
            return carrinho.ExibirInformacoes();
        }
    }
}
