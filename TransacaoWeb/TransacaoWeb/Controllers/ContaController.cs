
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransacaoWeb.DAO;
using TransacaoWeb.Models;

namespace TransacaoWeb.Controllers
{
    public class ContaController
    {
        static Random rnd = new Random();
        public static Conta GerarConta(double saldoInicial)
        {
            Conta conta;
            do
            {
                conta = new Conta()
                {
                    Agencia = GeraAgencia(),
                    Numero = GeraNumero(),
                    Saldo = saldoInicial
                };
            } while (ContaDAO.getConta(conta.Agencia, conta.Numero) != null);
            ContaDAO.Add(conta);
            return conta;
        }

        private static string GeraAgencia()
        {
            int numero = rnd.Next(1, 9999);
            int digito = rnd.Next(9);
            string agencia = numero.ToString("0000") + "-" + digito;
            return agencia;
        }

        private static string GeraNumero()
        {
            int numero = rnd.Next(1, 99999);
            int digito = rnd.Next(9);
            string conta = numero.ToString("00000") + "-" + digito;
            return conta;
        }

        public static void PedirCartao(string agencia, string numero)
        {
            Conta conta = getConta(agencia, numero);
            if (conta.CartaoId == 0)
            {
                Cartao cartao = CartaoController.PedirCartao();
                cartao.ContaId = conta.Id;
                conta.CartaoId = cartao.Id;
                ContaDAO.Update(conta);
            }
        }

        public static List<Conta> getContas()
        {

            return ContaDAO.getList();
        }

        public static Conta getConta(string agencia, string numero)
        {

            Conta conta = ContaDAO.getConta(agencia, numero);

            if (conta == null)
                throw new Exception("Conta não encontrada!");
            else
                return conta;
        }

        public static void Remover(Conta conta)
        {
            ContaDAO.Remove(conta);
        }

        public static Conta getContaById(int id)
        {
            return ContaDAO.getById(id);
        }

        public static void Update(Conta conta)
        {
            ContaDAO.Update(conta);
        }
    }
}