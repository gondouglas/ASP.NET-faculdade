using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModels
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public bool Ativo { get; set; }

    }
}
