using ArquiteturaDemo.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            Property(x => x.Name).IsRequired().HasMaxLength(100);

            Property(x => x.Price).IsRequired().HasPrecision(10, 2);
        }
    }
}
