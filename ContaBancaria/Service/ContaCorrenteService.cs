using ContaBancaria.Entidade;
using ContaBancaria.Entidade.Interfaces;
using ContaBancaria.Service.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Service
{
    public class ContaCorrenteService : IContaCorrenteService
    {
        private readonly IContaCorrente repository;
        public ContaCorrenteService(IContaCorrente carrinhoRepository)
        {
            repository = carrinhoRepository;
        }

        public void Adicionar(ContaPoupanca carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public ContaPoupanca BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(ContaPoupanca editPessoa)
        {
            repository.Editar(editPessoa);
        }

        public string ExibirInformacoes(int id)
        { 
            return repository.ExibirInformacoes(id);
        }

        public List<ContaPoupanca> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            throw new NotImplementedException();
        }
    }
}
