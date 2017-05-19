using Aula1805.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula1805.Controller
{
    public class OperationController
    {

        public static Operation getOperation(double num1, Operator op, double num2)
        {
            return new Operation(num1, op, num2);
        }
    }
}