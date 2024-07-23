using AutoMapper;
using IntegraBrasilApi.DTOs;

namespace IntegraBrasilApi.Services
{
    public class BancoServices : IBancoServices
    {
        private readonly IMapper _mapper;
        private readonly IBrasilApi _brasilAPi;

        public BancoServices(IMapper mapper, IBrasilApi brasilAPi)
        {
            _mapper = mapper;
            _brasilAPi = brasilAPi;
        }

        public async Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos()
        {
            var bancos = await _brasilAPi.BuscarTodosBancos();
            return _mapper.Map<ResponseGenerico<List<BancoResponse>>>(bancos);
        }
        public async Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilAPi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseGenerico<BancoResponse>>(banco);
        }

        
    }
}
