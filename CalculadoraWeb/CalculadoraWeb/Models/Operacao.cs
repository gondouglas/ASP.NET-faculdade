using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    class Operacao
    {

        public double OperacaoUm { get; set; }
        public double OperacaoDois { get; set; }
        public Operador Operador { get; set; }

        public double Resultado { get; }



        public Operacao(double num1, Operador op, double num2)
        {
            switch (op)
            {
                case Operador.SOMA:
                    Resultado = num1 + num2;
                    break;
                case Operador.SUBTRACAO:
                    Resultado = num1 - num2;
                    break;
                case Operador.MULTIPLICACAO:
                    Resultado = num1 * num2;
                    break;
                case Operador.DIVISAO:
                    Resultado = num1 / num2;
                    break;
            }
        }

    }
}

public enum Operador
{
    LIMPO,
    SOMA,
    SUBTRACAO,
    MULTIPLICACAO,
    DIVISAO
}
