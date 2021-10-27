using ArquiteturaDemo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class CidadeMap : EntityTypeConfiguration<Cidade>
    {
        public CidadeMap()
        {
            Property(x => x.Nome).IsRequired().HasMaxLength(200);
            Property(x => x.EstadoId).IsRequired();
        }
    }
}
