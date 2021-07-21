using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
          
            Exercise1_1(numbers);

            Console.WriteLine("-----------");
            Exercise1_2(numbers);

            Console.WriteLine("-----------");
            Exercise1_3(numbers);

            Console.WriteLine("-----------");
            Exercise1_4(numbers);
        }

        static void Exercise1_1(List<int> numbers)
        {
            var list = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
            Console.WriteLine(list);
        }

        static void Exercise1_2(List<int> numbers)
        {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        static void Exercise1_3(List<int> numbers)
        {
            var list = numbers.Where(n => n >= 50);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Exercise1_4(List<int> numbers)
        {
            var list = numbers.Select(n => n * 2).ToList();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
