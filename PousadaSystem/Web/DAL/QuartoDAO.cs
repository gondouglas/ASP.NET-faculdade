using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.DAL
{
    public class QuartoDAO : EntityBaseDAO<Quarto>
    {
        public static Quarto getByNumero(string numero, Context context)
        {
            return context.Quartos.Where(x => x.Numero.Equals(numero)).FirstOrDefault();
        }

        public static IEnumerable<Quarto> getByAndar(string andar, Context context)
        {
            return context.Quartos.Where(x => x.Andar.Equals(andar)).ToList();
        }

        public static IEnumerable<Quarto> getOcupados(Context context)
        {
            return context.Quartos.Where(x => x.Ocupado == true);
        }

        public static IEnumerable<Quarto> getLivres(Context context)
        {
            return context.Quartos.Where(x => x.Ocupado == false);
        }

        
    }
}