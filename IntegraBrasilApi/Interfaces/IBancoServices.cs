using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Services
{
    public interface IBancoServices
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();
        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);
    }
}
