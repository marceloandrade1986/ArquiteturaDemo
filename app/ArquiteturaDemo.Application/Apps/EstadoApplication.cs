using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;

namespace ArquiteturaDemo.Application.Apps
{
    class EstadoApplication : ApplicationBase
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoApplication(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }
    }
}
