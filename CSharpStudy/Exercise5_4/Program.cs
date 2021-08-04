using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "Novelist=김만중;BestWork=구운몽;Born=1687";

            foreach (var pair in input.Split(';'))
            {
                var array = pair.Split('=');
                Console.WriteLine("{0}:{1}", ToDictionary(array[0]), array[1]);
            }
        }

        static string ToDictionary(string key)
        {
            switch(key)
            {
                case "Novelist":
                    return "작가 ";
                case "BestWork":
                    return "대표작 ";
                case "Born":
                    return "출판연도 ";
            }
            throw new ArgumentException("ㅎㅎㅎㅎㅎㅎ");
        }
    }
}
