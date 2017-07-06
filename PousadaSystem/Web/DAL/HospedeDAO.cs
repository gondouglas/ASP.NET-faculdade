using EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.DAL
{
    public class HospedeDAO : EntityBaseDAO<Hospede>
    {
        public static Hospede getByCpf(string cpf, Context context)
        {
            return context.Hospedes.Where(x => x.Cpf.Equals(cpf)).FirstOrDefault();
        }

        public static Hospede getByEmail(string email, Context context)
        {
            return context.Hospedes.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }
    }
}