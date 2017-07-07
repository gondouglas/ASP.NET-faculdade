using System;
using System.Collections.Generic;
using System.Linq;
using Web.Models;

namespace Web.DAL
{
    public class EntityBaseDAO<T> where T : EntityModels.EntityBase
    {
        protected readonly ApplicationDbContext ctx = new ApplicationDbContext();
        public void Add(T t)
        {
            
            ctx.Set<T>().Add(t);
            ctx.SaveChanges();
        }

        public IEnumerable<T> getList()
        {
            return ctx.Set<T>().ToList();
        }

        public void Remove(T t)
        {
            t.Deletado = true;
            Update(t);
        }

        public void Active(T t)
        {
            t.Deletado = false;
            Update(t);
        }

        public void Update(T t)
        {
            ctx.Entry(t).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public  T getById(int id)
        {
            return ctx.Set<T>().Find(id);
        }

        public  IEnumerable<T> getDeletados(bool op)
        {
            return ctx.Set<T>().Where(x => x.Deletado == op);
        }
    }
}