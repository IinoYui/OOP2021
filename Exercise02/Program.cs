using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise1;

namespace Exercise02 {
    class Program {
            static void Main(string[] args) {

            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };

            //4.2.2
            Exrcise2_2(ymCollection);
            Console.WriteLine("------");

            //4.2.4
            Exrcise2_4(ymCollection);
            Console.WriteLine("------");

            //4.2.5
            Exrcise2_5(ymCollection);

        }

        //4.2.2
        private static void Exrcise2_2(YearMonth[] ymCollection) {
                foreach(var ym in ymCollection){
                    Console.WriteLine(ym);
                }
        }

        //4.2.4
        private static void Exrcise2_4(YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C(ymCollection);
            var s = yearmonth != null ? yearmonth.Year.ToString() : "２１世紀のデータはありません";
            Console.WriteLine(s);
        }

        //4.2.5
        private static void Exrcise2_5(YearMonth[] ymCollection) {
            var query = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            //AddOneMonth = 1month, ToArray = 配列化
                foreach(var ym in ymCollection) {
                Console.WriteLine(ym);
            }
            }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Centhry)
                    return ym;
            }
            //ここまで来たら21世紀が存在しない
            return null;
        }
    }
}
