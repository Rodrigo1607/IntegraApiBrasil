using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Services
{
    public interface IEnderecoServices
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
