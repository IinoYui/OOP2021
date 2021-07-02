using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {

    class Book {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }

    class Program {
        static void Main(string[] args) {

        var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

        Exercise2_1(books);
        Console.WriteLine("-----");

            Exercise2_2(books);

        Console.WriteLine("-----");

            Exercise2_3(books);
        Console.WriteLine("-----");

            Exercise2_4(books);
        Console.WriteLine("-----");

            Exercise2_5(books);
        Console.WriteLine("-----");

            Exercise2_6(books);

        Console.WriteLine("-----");

            Exercise2_7(books);
    }


        //タイトルが「ワンダフル・C#ライフ」である書籍の価格とページ数を表示
        private static void Exercise2_1(List<Book> books) {
            var book = books.FirstOrDefault(x => x.Title == "ワンダフル・C#ライフ");
          　if(book != null) {
                Console.WriteLine("{0},{1}", book.Price, book.Pages);
            }
        }

        //タイトルに「C#」と書かれている書籍が何冊あるかカウントする
        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine("タイトルに「C#」と書かれている書籍は" + books.Count(x => x.Title.Contains("C#")) + "冊");
        }

        //タイトルに「C#」と書かれている書籍の平均ページ数を求める
        private static void Exercise2_3(List<Book> books) {
            var average = books.Where(x => x.Title.Contains("C#")).Average(x => x.Pages).ToString();
            Console.WriteLine("タイトルに「C#」と書かれている書籍の平均ページ数は" + average + "ページ");
        }

        //価格が4000円遺以上の本で最初に見つかったタイトルを表示
        private static void Exercise2_4(List<Book> books) {
            var book = books.FirstOrDefault(x => x.Price >= 4000);
            if (book != null) {
                Console.WriteLine("価格が4000円以上の本で最初に見つかったタイトルは「" + book.Title + "」");
            }
        }

        //価格が4000円未満の本の中で最大のページ数を求める
        private static void Exercise2_5(List<Book> books) {
            var max = books.Where(x => x.Price < 4000).Max(x => x.Pages);
            Console.WriteLine(max);
        }

        //ページ数が400以上の書籍を価格の高い順にタイトルを表示
        private static void Exercise2_6(List<Book> books) {
            var selected = books.Where(x => x.Pages >= 400).OrderByDescending(x => x.Price);
            foreach(var book in selected) {
                Console.WriteLine("{0},{1}", book.Title, book.Price);
            }           
        }

        //タイトルの中に「C#」が含まれていてかつ、500ページ以下の本のタイトルを表示する
        private static void Exercise2_7(List<Book> books) {
            var selected = books.Where(x => x.Title.Contains("C#") && x.Pages <= 500);
            foreach(var book in selected) {
                Console.WriteLine(book.Title);
            }
        }
    }
}
