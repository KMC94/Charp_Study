using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1_1();
        }

        static void Exercise1_1()
        {
            Console.WriteLine("첫번째 문자열을 입력하시오.");
            string input = Console.ReadLine();

            Console.WriteLine("두번째 문자열을 입력하시오.");
            string input2 = Console.ReadLine();

            if (string.Compare(input, input2, ignoreCase: true) == 0)
                Console.WriteLine("두 문자열이 같읍니다.");
            else
                Console.WriteLine("두 문자열이 다릅니다.");
        }
    }
}
