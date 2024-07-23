using IntegraBrasilApi.Models;
using IntegraBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace IntegraBrasilApi.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoServices _bancoService;

        public BancoController(IBancoServices bancoService)
        {
            _bancoService = bancoService;
        }


        [HttpGet("busca/todos")]
        [ProducesResponseType(typeof(EnderecoModel), 200)]
        [ProducesResponseType(typeof(object), 400)]
        [ProducesResponseType(typeof(object), 500)]
        public async Task<IActionResult> BuscarTodos()
        {
            var response = await _bancoService.BuscarTodos();

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
        [HttpGet("busca/{codigoBanco}")]
        [ProducesResponseType(typeof(BancoModel), 200)]
        [ProducesResponseType(typeof(object), 400)]
        [ProducesResponseType(typeof(object), 404)]
        [ProducesResponseType(typeof(object), 500)]
        public async Task<IActionResult> BuscarBanco([RegularExpression(@"^\d{3}$", ErrorMessage = "Código do banco deve conter exatamente 3 dígitos numéricos.")] string codigoBanco)
        {
            var response = await _bancoService.BuscarBanco(codigoBanco);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

    }
}
