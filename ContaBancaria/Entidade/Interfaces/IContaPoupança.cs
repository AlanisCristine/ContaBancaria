using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Entidade.Interfaces
{
    public  interface IContaPoupança
    {
        void Adicionar(ContaPoupança carro);
        void Remover(int id);
        void Editar(ContaPoupança carrinho);
        List<ContaPoupança> Listar();
        ContaPoupança BuscarPorId(int id);
        string ExibirInformacoes(int id);
    }
}
