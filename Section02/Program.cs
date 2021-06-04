using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
    class Program {
        static void Main(string[] args) {

            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            
            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine();
            

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine();

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine();

            // 3.2.4
            Exercise2_4(names);
        }

        //入力して出す
        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力＞");
            var line = Console.ReadLine();  //入力データを取り込み
            var index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
         }

        //
        private static void Exercise2_2(List<string> names) {
           var count = names.Count(s => s.ToString().Contains('o'));
            Console.WriteLine(count);
        }

        //
        private static void Exercise2_3(List<string> names) {
            var query = names.Where(s => s.ToString().Contains('o'))
                             .ToArray();
            foreach (var s in query)
                Console.WriteLine(s);
        }

        //
        private static void Exercise2_4(List<string> names) {
            var query = names.Where(s => s.StartsWith("B"))
                             .Select(s => s.Length);
            foreach (int s in query)
                Console.WriteLine(s);
        }
    }
}
