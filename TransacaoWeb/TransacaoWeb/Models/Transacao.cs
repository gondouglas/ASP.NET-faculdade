using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TransacaoWeb.Models
{
    public class Transacao
    {
        [Key]
        public int Id { get; set; }
        public int ContaOrigemId { get; set; }
        public int ContaDestinoId { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }
}