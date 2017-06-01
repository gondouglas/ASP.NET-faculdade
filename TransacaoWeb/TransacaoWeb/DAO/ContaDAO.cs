using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransacaoWeb.Models;

namespace TransacaoWeb.DAO
{
    public class ContaDAO
    {

        public static Context ctx = Singleton.getInstance();

        public static void Add(Conta conta)
        {
            ctx.Contas.Add(conta);
            ctx.SaveChanges();
        }

        public static List<Conta> getList()
        {
            return ctx.Contas.ToList();
        }

        public static void Remove(Conta conta)
        {
            ctx.Entry(conta).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }

        public static void Update(Conta conta)
        {
            ctx.Entry(conta).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public static Conta getConta(string agencia, string numero)
        {
            return ctx.Contas.Where(x => x.Agencia.Equals(agencia.ToString()) && x.Numero.Equals(numero.ToString())).FirstOrDefault();
        }

        public static Conta getById(int id)
        {
            return ctx.Contas.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
    }
}