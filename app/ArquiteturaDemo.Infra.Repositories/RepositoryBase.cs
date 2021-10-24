using ArquiteturaDemo.Domain.Interfaces;
using ArquiteturaDemo.Infra.Repositories.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ArquiteturaDemo.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected ArquiteturaContext Context { get; private set; }

        public RepositoryBase()
        {
            Context = new ArquiteturaContext();
        }
        
        public void Add(TEntity obj)
        {
            Context.Set<TEntity>().Add(obj);   
        }

        public void Delete(TEntity obj)
        {
            Context.Set<TEntity>().Remove(obj);
        }

        public void Delete(int id)
        {
            var obj = Get(id);
            Delete(id);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> Get()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            Context.Entry(obj).State = EntityState.Modified;
        }
    }
}
