using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransacaoWeb.DAO;
using TransacaoWeb.Models;

namespace TransacaoWeb.Controllers
{
    public class CartaoController
    {

        public static Cartao PedirCartao()
        {
            Cartao cartao;
            do
            {
                cartao = new Cartao()
                {
                    Numero = GerarNumero(),
                    CodigoSeguranca = new Random().Next(1, 999).ToString("000")
                };
            } while (CartaoDAO.getCartao(cartao.Numero, cartao.CodigoSeguranca) != null);
            CartaoDAO.Add(cartao);
            return cartao;
        }

        private static string GerarNumero()
        {
            Random rnd = new Random();
            string grupo1 = rnd.Next(1, 9999).ToString("0000");
            string grupo2 = rnd.Next(1, 9999).ToString("0000");
            string grupo3 = rnd.Next(1, 9999).ToString("0000");
            string grupo4 = rnd.Next(1, 9999).ToString("0000");
            return grupo1 + "." + grupo2 + "." + grupo3 + "." + grupo4;
        }

        public static List<Cartao> getCartoes()
        {
            return CartaoDAO.getList();
        }

        public static Cartao getCartao(string numero, string cod)
        {
            Cartao cartao = CartaoDAO.getCartao(numero, cod);
            if (cartao == null)
                throw new Exception("Cartão não encontrado!");
            else
                return cartao;
        }

        public static void Remover(Cartao cartao)
        {
            Conta conta = ContaController.getContaById(cartao.ContaId);
            if (conta != null)
            {
                conta.CartaoId = 0;
                ContaController.Update(conta);
            }
            CartaoDAO.Remove(cartao);
        }

        public static Cartao getById(int id)
        {
            return CartaoDAO.getById(id);
        }
    }
}