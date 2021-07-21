using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //Exercise2_1(names);
            //Console.WriteLine("-----------");

            //Exercise2_2(names);
            //Console.WriteLine("-----------");

            //Exercise2_3(names);
            //Console.WriteLine("-----------");

            Exercise2_4(names);
            Console.WriteLine("-----------");
        }

        static void Exercise2_1(List<string> names)
        {
            var line = Console.ReadLine();

            Console.WriteLine(names.FindIndex(s => s == line));
        }

        static void Exercise2_2(List<string> names)
        {
            Console.WriteLine(names.Count(s => s.Contains('o')));
        }

        static void Exercise2_3(List<string> names)
        {
            var list = names.Where(s => s.Contains('o'));

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Exercise2_4(List<string> names)
        {
            var list = names.Where(s => s.StartsWith("B"))
                            .Select(s => s.Length);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
