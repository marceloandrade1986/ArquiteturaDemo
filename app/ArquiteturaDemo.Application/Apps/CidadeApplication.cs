using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;

namespace ArquiteturaDemo.Application.Apps
{
    class CidadeApplication : ApplicationBase
    {
        private readonly ICidadeRepository _cidadeRepository;

        public CidadeApplication(ICidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }
    }
}
