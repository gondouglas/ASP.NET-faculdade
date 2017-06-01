using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransacaoWeb.Models
{
    public class Singleton
    {
        private static Context context;

        public static Context getInstance()
        {
            if (context == null)
            {
                context = new Context();
                return context;
            }
            else
            {
                return context;
            }
        }
    }
}