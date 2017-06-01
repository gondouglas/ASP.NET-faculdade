using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TransacaoWeb.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }
        public string Agencia { get; set; }
        public string Numero { get; set; }
        public int CartaoId { get; set; }
        public double Saldo { get; set; }

    }
}