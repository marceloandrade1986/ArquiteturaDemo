using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace ArquiteturaDemo.Infra.Repositories
{
    public class PrevisaoClimaRepository : RepositoryBase<PrevisaoClima>, IPrevisaoClimaRepository
    {
        public List<PrevisaoClima> CidadesMaisFrias()
        {
            return Context.Set<PrevisaoClima>().Include(x => x.Cidade).Where(x => x.TemperaturaMinima < 5 && x.TemperaturaMaxima <= 7).Take(3).ToList();
        }

        public List<PrevisaoClima> CidadesMaisQuentes()
        {
            return Context.Set<PrevisaoClima>().Include(x => x.Cidade).Where(x => x.TemperaturaMaxima >= 30).Take(3).ToList();
        }

        public List<PrevisaoClima> Previsao7dias(int cidadeId)
        {
            return Context.Set<PrevisaoClima>().Where(x => x.CidadeId == cidadeId).ToList();
        }
    }
}
