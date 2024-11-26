using ContaBancaria.Entidade;
using ContaBancaria.Service.Interfces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly IContaCorrenteService _service;

        public ContaCorrenteController(IContaCorrenteService service)
        {
            _service = service;
        }

        [HttpPost("Adicionar-Conta-Corrente")]
        public void AdicionarAluno(ContaPoupanca carrinho)
        {
            _service.Adicionar(carrinho);
        }
        [HttpGet("Listar-Conta-Corrente")]
        public List<ContaPoupanca> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpGet("Exibir-Informacoes-Conta-Corrente")]
        public string ExibirInformcoes(int id)
        {
            return _service.ExibirInformacoes(id);
        }

        [HttpPut("Editar-Conta-Corrente")]
        public void EditarCarrinho(ContaPoupanca p)
        {
            _service.Editar(p);
        }
        [HttpDelete("Deletar-Conta-Corrente")]
        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }
    }
}
