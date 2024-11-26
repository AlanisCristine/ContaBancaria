using ContaBancaria.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Service.Interfces
{
    public interface IContaCorrenteService
    {
         void Adicionar(ContaPoupanca carrinho);
         ContaPoupanca BuscarTimePorId(int id);
         void Editar(ContaPoupanca editPessoa);
         List<ContaPoupanca> Listar();
         void Remover(int id);
        string ExibirInformacoes(int id);
    }
}
