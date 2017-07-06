using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class Singleton
    {

        private static Context ctx;

        public static Context getInstance()
        {
            if(ctx == null)
            {
                ctx = new Context();
                return ctx;
            }
            else
            {
                return ctx;
            }
        }
    }
}