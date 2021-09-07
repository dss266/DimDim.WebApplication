using CP2SEM.DAO.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP2SEM.DAO
{
    public class MainDAO<TEntity> where TEntity : class
    {
        protected MainContext context = new MainContext();

        public void Add(TEntity obj)
        {
            context.Set<TEntity>().Add(obj);
            context.SaveChanges();
        }

        public void Dispose()
        {

        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            context.Set<TEntity>().Remove(obj);
            context.SaveChanges();

        }

        public void Update(TEntity obj)
        {
            context.Update(obj);
            context.SaveChanges();

        }
    }
}
