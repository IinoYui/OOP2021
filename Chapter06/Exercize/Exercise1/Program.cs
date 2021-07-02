using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }

        //最大値表示
        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max); 
        }

        //最後から2つの要素を取り出す
        private static void Exercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach (var n in numbers.Skip(skip))
                Console.WriteLine(n);
        }

        //数値を文字列に変換し、結果を表示
        private static void Exercise1_3(int[] numbers) {
            var numnum = numbers.Select(n => n.ToString());
            foreach(var n in numnum)
                Console.WriteLine(n);
        }

        //小さい順に並べ、先頭から3つを取り出す
        private static void Exercise1_4(int[] numbers) {
            var nums = numbers.OrderBy(n => n).Take(3);
            foreach(var n in nums)
                Console.WriteLine(n);
        }

        //重複を排除した後、10より大きい値がいくつあるのかをカウントし結果を表示する
        private static void Exercise1_5(int[] numbers) {
            var results = numbers.Distinct();
            Console.WriteLine(numbers.Where(n => n > 10).Count());
         
        }
    }
}
