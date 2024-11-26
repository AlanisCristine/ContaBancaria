using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidade.Interfaces
{
    public interface IContaCorrente
    {
        void Adicionar(ContaPoupanca carro);
        void Remover(int id);
        void Editar(ContaPoupanca carrinho);
        List<ContaPoupanca> Listar();
        ContaPoupanca BuscarPorId(int id);
        string ExibirInformacoes(int id);
    }
}
