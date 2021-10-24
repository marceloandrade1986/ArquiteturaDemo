using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ArquiteturaDemo.Infra.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return Context.Products.Where(x => x.Price == price).ToList();
        }
    }
}
