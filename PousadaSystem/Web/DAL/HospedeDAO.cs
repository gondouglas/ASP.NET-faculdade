using EntityModels;
using System.Linq;
using Web.Models;

namespace Web.DAL
{
    public class HospedeDAO : EntityBaseDAO<Hospede>
    {
        public Hospede getByCpf(string cpf)
        {
            return ctx.Hospedes.Where(x => x.Cpf.Equals(cpf)).FirstOrDefault();
        }

        public Hospede getByEmail(string email)
        {
            return ctx.Hospedes.Where(x => x.Email.Equals(email)).FirstOrDefault();
        }
    }
}