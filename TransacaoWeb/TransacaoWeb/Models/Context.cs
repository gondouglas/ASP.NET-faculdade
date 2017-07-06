using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TransacaoWeb.Models
{
    public class Context : DbContext
    {
        public Context() : base("TransacaoDB")
        {
        }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<Transacao> Transacao { get; set; }

    }
}