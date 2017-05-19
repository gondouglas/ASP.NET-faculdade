using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula1805.Models
{
    public class Operation
    {

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public Operator Operator { get; set; }
        public double Resultado { get; set; }

        public Operation(double num1, Operator op, double num2)
        {
            Num1 = num1;
            Num2 = num2;
            Operator = op;
            Resultado = getResultado();
        }

        private double getResultado()
        {
            switch (Operator)
            {
                case Operator.SUM:
                    return Num1 + Num2;
                case Operator.SUBTRACT:
                    return Num1 - Num2;
                case Operator.MULTIPLY:
                    return Num1 * Num2;
                case Operator.DIVIDE:
                    return Num1 / Num2;
            }
            return 0;
        }

    }

    public enum Operator
    {
        SUM,
        SUBTRACT,
        MULTIPLY,
        DIVIDE
    }
}