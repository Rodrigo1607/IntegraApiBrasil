using AutoMapper;
using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;
using System.Runtime.CompilerServices;

namespace IntegraBrasilApi.Services
{
    public class EnderecoServices : IEnderecoServices
    {
        private readonly IMapper _mapper;   
        private readonly IBrasilApi _brasilApi;

        public EnderecoServices(IMapper mapper, IBrasilApi brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);
            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
