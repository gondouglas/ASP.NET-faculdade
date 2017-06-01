using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransacaoWeb.Models;

namespace TransacaoWeb.DAO
{
    public class TransacaoDAO
    {
        public static Context ctx = Singleton.getInstance();

        public static void Add(Transacao transacao)
        {
            ctx.Transacao.Add(transacao);
            ctx.SaveChanges();
        }

        public static List<Transacao> getList()
        {
            return ctx.Transacao.ToList();
        }

        public static void Remove(Transacao transacao)
        {
            ctx.Entry(transacao).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }

        public static void Update(Transacao transacao)
        {
            ctx.Entry(transacao).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }
    }
}