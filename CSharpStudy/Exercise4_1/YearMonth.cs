using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_1
{
    public class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }

        public bool Is21Century
        {
            get
            {
                return 2001 <= Year && Year <= 2100;
            }
        }

        public YearMonth(int year, int month)
        {
            Year = year;
            Month = month;
        }
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
        }

        public YearMonth AddOneMonth()
        {
            if(Month == 12)
            {
                return new YearMonth(this.Year + 1, 1);
            }
            else
            {
                return new YearMonth(this.Year + 1, this.Month + 1);
            }
        }

        public override string ToString()
        {
            return $"{Year}년 {Month}월";
        }
    }
}
