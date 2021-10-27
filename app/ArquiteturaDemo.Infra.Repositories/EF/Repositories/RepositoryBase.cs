using ArquiteturaDemo.Domain.Interfaces;
using ArquiteturaDemo.Infra.Repositories.EF;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ArquiteturaDemo.Infra.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {

        protected DbContext Context { get; private set; }

        //protected ArquiteturaContext Context { get; private set; }

        public RepositoryBase()
        {
            var contextManager = ServiceLocator.Current.GetInstance<ContextManager>();

            Context = contextManager.Context;

            //Context = new ArquiteturaContext();
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
