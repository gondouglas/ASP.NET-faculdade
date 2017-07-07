using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class Hospede : EntityBase
    {

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public List<Estadia> Estadias { get; set; }
    }
}
