using IntegraBrasilApi.Models;
using IntegraBrasilApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace IntegraBrasilApi.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoServices _enderecoService;

        public EnderecoController(IEnderecoServices enderecoService)
        {
            _enderecoService = enderecoService;
        }
        [HttpGet("busca/{cep}")]
        [ProducesResponseType(typeof(EnderecoModel), 200)]
        [ProducesResponseType(typeof(object), 400)]
        [ProducesResponseType(typeof(object), 404)]
        [ProducesResponseType(typeof(object), 500)]
        public async Task<IActionResult> BuscarEndereco([FromRoute] string cep)
        {
            var response = await _enderecoService.BuscarEndereco(cep);

            if(response.CodigoHttp==HttpStatusCode.OK)
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
