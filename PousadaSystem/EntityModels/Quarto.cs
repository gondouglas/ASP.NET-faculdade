using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Quarto : EntityBase
    {
        public string Numero { get; set; }
        public string Andar { get; set; }
        public double ValorDiaria { get; set; }
        public bool Ocupado { get; set; }

        public List<Estadia> Estadias { get; set; }
    }
}
