using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintInchToMeterList(1, 10);
        }

        // 인치에서 미터로의 환산표를 출력
        static void PrintInchToMeterList(int start, int stop)
        {
            for(int inch = start; inch <= stop; inch++)
            {
                double meter = InchToMeter(inch);
                Console.WriteLine("{0}inch = {1:0.0000} m", inch, meter);
            }
        }

        private static double InchToMeter(int inch)
        {
            return inch * 0.0254;
        }

        // 피트에서 미터로의 환산표를 출력
        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = InchConverter.FromMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        // 미터에서 피트로의 환산표를 출력
        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = InchConverter.ToMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
