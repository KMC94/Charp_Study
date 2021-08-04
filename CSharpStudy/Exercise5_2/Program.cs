using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int result))
                Console.WriteLine($"{result:#,#}");
            else
                Console.WriteLine("숫자값 문자열이 아닙니다");
        }
    }
}
