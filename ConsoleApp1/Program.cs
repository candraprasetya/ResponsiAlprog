using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var transact = new Transaction();

            Process.GetInstance.WriteFile(transact);
            transact.Sales();
            transact.PreSales();

            Process.GetInstance.ReadFile(ref transact);
            Console.ReadKey();

        }
    }
}
