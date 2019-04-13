using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transaction
    {
        public string Invoice { get; set; }
        public string Currdate { get; set; }
        public Dishes Dish { get; set; }

        public Transaction()
        {
            Dish = new Dishes();
            Invoice = "N1/2019/01";
            Currdate = Convert.ToDateTime(DateTime.Now).ToString("dd-MM-yy");
        }

        public void Sales()
        {
            var sales = $"Invoice: {Invoice}; Current Date: {Currdate}; ";
            Console.WriteLine(sales);
        }

        public void PreSales()
        {
            Console.WriteLine(Dish.Info());
        }

        public void ChangeDue()
        {
            if (Dish == null) return;
            Console.WriteLine(PlusPPn());
        }

        public double PlusPPn()
        {
            var tax = 1.1;
            tax *= Dish.Price;
            return tax;
        }
    }
}
