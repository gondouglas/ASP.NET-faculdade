using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransacaoWeb.DAO;
using TransacaoWeb.Models;

namespace TransacaoWeb.Controllers
{
    public class TransacaoController
    {

        public static void EfetuarTransacao(Transacao transacao)
        {
            Conta origem = ContaController.getContaById(transacao.ContaOrigemId);
            Conta destino = ContaController.getContaById(transacao.ContaDestinoId);
            if(origem.Saldo < transacao.Valor)
            {
                throw new Exception("Saldo insuficiente!");
            }
            origem.Saldo -= transacao.Valor;
            destino.Saldo += transacao.Valor;
            ContaController.Update(origem);
            ContaController.Update(destino);
            TransacaoDAO.Add(transacao);
        }

        public static List<Transacao> getTransacoes()
        {
            return TransacaoDAO.getList();
        }
    }
}