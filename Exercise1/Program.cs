using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {

            //2.1.3
            var songs = new Song[] {
                new Song("のび太くん０点","野比のび太",168),
                new Song("おとなりのプリンセス","源静香",158),
                new Song("スネ夫のおぼっちゃマンボ","骨川スネ夫",191),
                new Song("ジャイアンにボエボエ","剛田武",168),
                new Song("ひみつ道具数え歌","ドラえもん",250),
            };
            PrintSongs(songs);

        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {

            foreach(var song in songs) {
                Console.WriteLine("{0},{1},{2}:{3}",song.Title, song.ArtistName, (song.Length/60),(song.Length%60));
            }
        }
    }
}
