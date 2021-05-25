﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1, 10);
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1, 10);
            }
        }

        //フィールからメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start, int stop) {
            for (int feet = start; feet <= start; feet++) {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000}m", feet, meter);
            }
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            for(int meter = start; meter <= stop; meter++) {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} m", meter, feet);
            }
        }
    
    }
}
