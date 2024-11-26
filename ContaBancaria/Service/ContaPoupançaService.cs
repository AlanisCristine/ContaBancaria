using ContaBancaria.Entidade.Interfaces;
using ContaBancaria.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContaBancaria.Service.Interfces;

namespace ContaBancaria.Service
{
    public class ContaPoupançaService : IContaPoupançaService
    {
        private readonly IContaPoupança repository;
        public ContaPoupançaService(IContaPoupança carrinhoRepository)
        {
            repository = carrinhoRepository;
        }

        public void Adicionar(ContaPoupança carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public ContaPoupança BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(ContaPoupança editPessoa)
        {
            repository.Editar(editPessoa);
        }

        public string ExibirInformacoes(int id)
        {
            return repository.ExibirInformacoes(id);
        }

        public List<ContaPoupança> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }
    }
}

