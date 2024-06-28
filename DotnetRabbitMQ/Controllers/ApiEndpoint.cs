using DotnetRabbitMQ.Relatorios;
using Microsoft.AspNetCore.Mvc;

namespace DotnetRabbitMQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiEndpoint : ControllerBase
    {
        [HttpGet("relatorios")]
        public async Task<IActionResult> GetRelatorios()
        {
            var relatorios = Lista.Relatorios;
            return Ok(relatorios);
        }

        [HttpPost("solicitar-relatorio/{nome}")]
        public async Task<IActionResult> PostRelatorio(string nome)
        {
            var solicitacao = new SolicitacaoRelatorio()
            {
                IdSolicitacao = Guid.NewGuid(),
                Nome = nome,
                Status = "Pendente",
                DataProcessamento = null
            };

            Lista.Relatorios.Add(solicitacao);

            return Ok(solicitacao);
        }
    }
}
