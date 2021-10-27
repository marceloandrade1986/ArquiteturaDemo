using ArquiteturaDemo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    class PrevisaoClimaMap : EntityTypeConfiguration<PrevisaoClima>
    {
        public PrevisaoClimaMap()
        {
            Property(x => x.Clima).IsRequired();
            Property(x => x.TemperaturaMinima).IsRequired();
            Property(x => x.TemperaturaMaxima).IsRequired();
            Property(x => x.DataPrevisao).IsRequired();
            Property(x => x.CidadeId).IsRequired();
        }
    }
}
