﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1, 10);
            }
        }


        // 피트에서 미터로의 환산표를 출력
        static void PrintFeetToMeterList(int start, int stop)
        {
            // 피트에서 미터로의 환산표를 출력
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }

        // 미터에서 피트로의 환산표를 출력
        static void PrintMeterToFeetList(int start, int stop)
        {
            // 미터에서 피트로의 환산표를 출력
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }

        // 피트를 미터로 환산한다
        private static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }

        // 미터를 피트로 환산한다
        private static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }

        
    }
}