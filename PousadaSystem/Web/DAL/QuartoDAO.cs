using EntityModels;
using System.Collections.Generic;
using System.Linq;

namespace Web.DAL
{
    public class QuartoDAO : EntityBaseDAO<Quarto>
    {
        public Quarto getByNumero(string numero)
        {
            
            return ctx.Quartos.Where(x => x.Numero.Equals(numero)).FirstOrDefault();
        }

        public IEnumerable<Quarto> getByAndar(string andar)
        {
            return ctx.Quartos.Where(x => x.Andar.Equals(andar)).ToList();
        }

        public IEnumerable<Quarto> getOcupados()
        {
            return ctx.Quartos.Where(x => x.Ocupado == true);
        }

        public IEnumerable<Quarto> getLivres()
        {
            return ctx.Quartos.Where(x => x.Ocupado == false);
        }

        
    }
}