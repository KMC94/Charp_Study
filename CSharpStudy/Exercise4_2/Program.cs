using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise4_1;

namespace Exercise4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            YearMonth[] yearMonths = new YearMonth[]
            {
                new YearMonth(1994, 6),
                new YearMonth(1992, 4),
                new YearMonth(1998, 3),
                new YearMonth(1965, 10),
                new YearMonth(1966, 11),
            };
            foreach (var item in yearMonths)
            {
                Console.WriteLine($"{item.Year}년 {item.Month}월");
            }

            Exercise4_2(yearMonths);
            Console.WriteLine("---------------");

            Exercise4_4(yearMonths);
            Console.WriteLine("---------------");

            Exercise4_5(yearMonths);
            Console.WriteLine("---------------");
        }

        static YearMonth Exercise4_2(YearMonth[] yearMonths)
        {
            foreach (var item in yearMonths)
            {
                if(item.Is21Century)
                    return item;
            }
            return null;
        }

        static void Exercise4_4(YearMonth[] yearMonths)
        {
            YearMonth yearMonth = Exercise4_2(yearMonths);

            if(yearMonth == null)
                Console.WriteLine("21세기 데이터는 없습니다.");
            else
                Console.WriteLine($"{yearMonth.Year}년도");
        }

        static void Exercise4_5(YearMonth[] yearMonths)
        {
            YearMonth[] addOneMonths = yearMonths.Select(ym => ym.AddOneMonth()).ToArray();

            foreach (var item in addOneMonths)
            {
                Console.WriteLine($"{item.Year}년 {item.Month}월");
            }
        }
    }
}
