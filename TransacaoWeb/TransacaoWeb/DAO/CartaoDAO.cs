using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransacaoWeb.Models;

namespace TransacaoWeb.DAO
{
    public class CartaoDAO
    {
        public static Context ctx = Singleton.getInstance();

        public static void Add(Cartao cartao)
        {
            ctx.Cartoes.Add(cartao);
            ctx.SaveChanges();
        }

        public static List<Cartao> getList()
        {
            return ctx.Cartoes.ToList();
        }

        public static void Remove(Cartao cartao)
        {
            ctx.Entry(cartao).State = System.Data.Entity.EntityState.Deleted;
            ctx.SaveChanges();
        }

        public static void Update(Cartao cartao)
        {
            ctx.Entry(cartao).State = System.Data.Entity.EntityState.Modified;
            ctx.SaveChanges();
        }

        public static Cartao getCartao(string numero, string codigo)
        {
            return ctx.Cartoes.Where(x => x.Numero.Equals(numero) && x.CodigoSeguranca.Equals(codigo)).FirstOrDefault();
        }

        public static Cartao getById(int id)
        {
            return ctx.Cartoes.Where(x => x.Id.Equals(id)).FirstOrDefault();

        }
    }
}