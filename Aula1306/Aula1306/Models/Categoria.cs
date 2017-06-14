using System;
using System.ComponentModel.DataAnnotations;

namespace Aula1306.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nome { get; set; }
        [Required(ErrorMessage ="Favor preencher o nome!")]
        [Display(Name = "Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

    }
}