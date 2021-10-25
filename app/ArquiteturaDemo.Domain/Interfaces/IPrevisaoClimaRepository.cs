using ArquiteturaDemo.Domain.Entities;
using System.Collections.Generic;

namespace ArquiteturaDemo.Domain.Interfaces
{
    public interface IPrevisaoClimaRepository : IRepositoryBase<PrevisaoClima>
    {
        List<PrevisaoClima> CidadesMaisFrias();
        List<PrevisaoClima> CidadesMaisQuentes();
        List<PrevisaoClima> Previsao7dias(int cidadeId);
    }
}
