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

        public void Adicionar(ContaCorrente carrinho)
        {
            repository.Adicionar(carrinho);
        }

        public ContaCorrente BuscarTimePorId(int id)
        {
            return repository.BuscarPorId(id);
        }

        public void Editar(ContaCorrente editPessoa)
        {
            repository.Editar(editPessoa);
        }

        public List<ContaCorrente> Listar()
        {
            return repository.Listar();
        }

        public void Remover(int id)
        {
            repository.Remover(id);
        }
    }
}
