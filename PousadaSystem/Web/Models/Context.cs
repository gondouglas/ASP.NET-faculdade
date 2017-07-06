using EntityModels;
using System.Data.Entity;

namespace Web.Models
{
    public class Context : DbContext
    {
        public Context() : base("InnDB")
        {

        }

        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Estadia> Estadias { get; set; }
    }
}