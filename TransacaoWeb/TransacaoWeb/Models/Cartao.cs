using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TransacaoWeb.Models
{
    public class Cartao
    {
        [Key]
        public int Id { get; set; }
        public string Numero { get; set; }
        public string CodigoSeguranca { get; set; }
        public int ContaId { get; set; }
        public List<Transacao> Transacoes { get; set; }

    }
}