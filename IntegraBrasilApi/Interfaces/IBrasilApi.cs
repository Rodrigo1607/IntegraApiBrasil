using IntegraBrasilApi.DTOs;
using IntegraBrasilApi.Models;

namespace IntegraBrasilApi.Services
{
    public interface IBrasilApi
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCep (string cep);
        Task<ResponseGenerico<List<BancoModel>>>BuscarTodosBancos();
        Task<ResponseGenerico<BancoModel>>BuscarBanco(string codigoBanco);
    }
}
