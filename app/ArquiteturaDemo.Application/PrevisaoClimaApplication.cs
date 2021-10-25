using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;

namespace ArquiteturaDemo.Application
{
    class PrevisaoClimaApplication : ApplicationBase
    {
        private readonly IPrevisaoClimaRepository _previsaoClimaRepository;

        public PrevisaoClimaApplication(IPrevisaoClimaRepository climaRepository)
        {
            _previsaoClimaRepository = climaRepository;
        }

        public void Get(PrevisaoClima previsaoClima)
        {
            BeginTrasanction();

            _previsaoClimaRepository.Get();

            Commit();
        }
    }
}
