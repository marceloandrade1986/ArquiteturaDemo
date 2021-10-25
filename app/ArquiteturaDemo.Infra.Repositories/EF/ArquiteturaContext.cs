using ArquiteturaDemo.Domain.Entities;
using System.Data.Entity;

namespace ArquiteturaDemo.Infra.Repositories.EF
{
    public class ArquiteturaContext : DbContext
    {
        public ArquiteturaContext() : base("Default") { }  
        public DbSet<Product> Products { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<PrevisaoClima> PrevisaoClimas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new PrevisaoClimaMap());
        }

    }
}
