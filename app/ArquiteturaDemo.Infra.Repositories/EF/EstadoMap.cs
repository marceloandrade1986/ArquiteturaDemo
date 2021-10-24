using ArquiteturaDemo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class EstadoMap : EntityTypeConfiguration<Estado>
    {
        public EstadoMap()
        {
            Property(x => x.Nome).IsRequired().HasMaxLength(200);
            Property(x => x.UF).IsRequired().HasMaxLength(2);
        }
    }
}
