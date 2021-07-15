using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter("sales.csv");
            var amountPerStore = sales.GetPerProductSales();
            foreach (var obj in amountPerStore)
            {
                Console.WriteLine("{0} {1:#,#}원", obj.Key, obj.Value);
            }
        }
    }
}
