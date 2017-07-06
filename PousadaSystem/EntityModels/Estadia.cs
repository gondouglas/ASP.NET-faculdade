using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Estadia : EntityBase
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }

        public int QuantidadeDias { get; set; }
        public double ValorTotal { get; set; }

        public int QuartoID { get; set; }
        public int HospedeID { get; set; }

        [ForeignKey("QuartoID")]
        public virtual Quarto _Quarto { get; set; }
        [ForeignKey("HospedeID")]
        public virtual Hospede _Hospede { get; set; }
    }
}
