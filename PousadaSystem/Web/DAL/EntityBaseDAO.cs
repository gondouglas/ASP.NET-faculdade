using System;
using System.Collections.Generic;
using System.Linq;
using Web.Models;

namespace Web.DAL
{
    public class EntityBaseDAO<T> where T : EntityModels.EntityBase
    {

        public static void Add(T t, Context context)
        {
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public static IEnumerable<T> getList(Context context)
        {
            return context.Set<T>().ToList();
        }

        public static void Remove(T t, Context context)
        {
            t.Deletado = true;
        }

        public static void Active(T t, Context context)
        {
            t.Deletado = false;
        }

        public static void Update(T t, Context context)
        {
            context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public static T getById(int id, Context context)
        {
            return context.Set<T>().Find(id);
        }

        public static IEnumerable<T> getDeletados(bool op, Context context)
        {
            return context.Set<T>().Where(x => x.Deletado == op);
        }
    }
}