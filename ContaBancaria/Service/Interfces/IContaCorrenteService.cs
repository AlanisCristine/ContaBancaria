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
        public void Adicionar(ContaCorrente carrinho);
        public ContaCorrente BuscarTimePorId(int id);
        public void Editar(ContaCorrente editPessoa);
        public List<ContaCorrente> Listar();
        public void Remover(int id);
    }
}
