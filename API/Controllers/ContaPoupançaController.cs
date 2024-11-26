using ContaBancaria.Entidade;
using ContaBancaria.Service.Interfces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaPoupançaController : ControllerBase
    {
        private readonly IContaPoupançaService _service;

        public ContaPoupançaController(IContaPoupançaService service)
        {
            _service = service;
        }

        [HttpPost("Adicionar-Conta-Poupança")]
        public void AdicionarAluno(ContaPoupança carrinho)
        {
            _service.Adicionar(carrinho);
        }
        [HttpGet("Listar-Conta-Poupança")]
        public List<ContaPoupança> ListarAluno()
        {
            return _service.Listar();
        }

        [HttpGet("Exibir-Informacoes-Conta-Poupança")]
        public string ExibirInformacoes(int id)
        {
            return _service.ExibirInformacoes(id);
        }

        [HttpPut("Editar-Conta-Poupança")]
        public void EditarCarrinho(ContaPoupança p)
        {
            _service.Editar(p);
        }

        [HttpDelete("Deletar-Conta-Poupança")]
        public void DeletarCarrinho(int id)
        {
            _service.Remover(id);
        }
    }
}
