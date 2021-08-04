using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(input);
            Exercise3_2(input);
            Exercise3_3(input);
            Exercise3_4(input);
            Exercise3_5(input);
        }

        static void Exercise3_1(string input)
        {
            int spaces = input.Count(s => s == ' ');
            Console.WriteLine("공백 수는 {0} ", spaces);
        }

        static void Exercise3_2(string input)
        {
            var replace = input.Replace("big", "small");
            Console.WriteLine(replace);
        }

        static void Exercise3_3(string input)
        {
            var count = input.Split(' ').Length;
            Console.WriteLine("단어의 개수 = {0}", count);
        }

        static void Exercise3_4(string input)
        {
            var temp = input.Split(' ').Where(s => s.Length <= 4);

            foreach (var item in temp)
            {
                Console.WriteLine(item + " ");
            }
        }

        static void Exercise3_5(string input)
        {
            var array = input.Split(' ').ToArray();

            if (array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array)
                {
                    sb.Append(' ');
                    sb.Append(word);
                }
                var clone = sb.ToString();
                Console.WriteLine(clone);
            }
        }

    }
}
