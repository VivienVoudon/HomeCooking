using HomeCooking.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCooking.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AccountServices services = new AccountServices();
            services.Test();

        }
    }
}
