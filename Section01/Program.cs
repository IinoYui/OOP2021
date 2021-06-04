using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };


            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);


        }


        //8か9で割り切れる数があるか
        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists( n => n % 8 == 0 || n % 9 ==0 );

            if (exist)
                Console.WriteLine("存在しています。");
            else
                Console.WriteLine("存在していません。");
        }


        //各要素を2.0で割った値
        private static void Exercise1_2(List<int> numbers) {
            var exist = numbers.FindAll(n => n / 2 == 0);
            foreach(var n in numbers)
                Console.WriteLine(n);
        }


        //値が50以上の要素を列挙する
        private static void Exercise1_3(List<int> numbers) {
            var query = numbers.Where(n => n >=  50);
            foreach (int n in query)
                Console.WriteLine(n);

            //上の文と同じ意味↑
            //numbers.Where(n => n >= 50).ToList().ForEach(Console.WriteLine);
        }


        //値を2倍にする
        private static void Exercise1_4(List<int> numbers) {
            var query = numbers.Select(n => n * 2);
            foreach (var n in query)
                Console.WriteLine(n);
        }
    }
}