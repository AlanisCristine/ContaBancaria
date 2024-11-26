using ContaBancaria.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Service.Interfces
{
    public interface IContaPoupançaService
    {
         void Adicionar(ContaPoupança carrinho);
         ContaPoupança BuscarTimePorId(int id);
         void Editar(ContaPoupança editPessoa);
        List<ContaPoupança> Listar();
        void Remover(int id);
        string ExibirInformacoes(int id);
    }
}
