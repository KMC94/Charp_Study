using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Exercise6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("---------");
            Exercise1_2(numbers);
            Console.WriteLine("---------");
            Exercise1_3(numbers);
            Console.WriteLine("---------");
            Exercise1_4(numbers);
            Console.WriteLine("---------");
            Exercise1_5(numbers);
            Console.WriteLine("---------");
        }

        static void Exercise1_1(int[] numbers)
        {
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        static void Exercise1_2(int[] numbers)
        {
            var skip = numbers.Length - 2;
            foreach (var item in numbers.Skip(skip))
            {
                Console.WriteLine(item);
            }
        }

        static void Exercise1_3(int[] numbers)
        {
            var strs = numbers.Select(s => s.ToString());
            foreach (var item in strs)
            {
                Console.WriteLine(item);
            }
        }

        static void Exercise1_4(int[] numbers)
        {
            foreach (var item in numbers.OrderBy(n => n).Take(3))
            {
                Console.WriteLine(item);
            }
        }

        static void Exercise1_5(int[] numbers)
        {
            var count = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(count);
        }
    }
}
