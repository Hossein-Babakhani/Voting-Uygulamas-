using System;
using System.Collections;

namespace Voting_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kategoriler = { "Film", "Teknoloji", "Spor" };
            ArrayList kullanıcılar = new ArrayList();
            int voteFilm = 0, voteTekn = 0, voteSpor = 0;

        start:
            Console.WriteLine("Lütfen username i girinz. Kullanıcı değilseniz n ye basınız.");
            string s = Console.ReadLine();
            if (kullanıcılar.Contains(s))
            {
                Console.WriteLine("Lütfen Film,Teknoloji,Spor kategorilerinden birini giriniz.");
                string voteSecim = Console.ReadLine().ToLower();
                if (voteSecim == "film")
                    voteFilm++;
                else if (voteSecim == "teknoloji")
                    voteTekn++;
                else if (voteSecim == "spor")
                    voteSpor++;
                else
                    Console.WriteLine("Yanlış kategori giriniz.");
            }
            else if (s == "n")
            {
                Console.WriteLine("Sisteme kaydedilecek olan username i girinz.");
                string username = Console.ReadLine();
                kullanıcılar.Add(username);
                goto start;
            }
            else
            {
                Console.WriteLine("Yanlış giriş! Lütfen yeniden deneyiniz.");
                goto start;
            }
            Console.WriteLine("Film oyu: " + voteFilm + " yüzde: " + voteFilm / (voteFilm + voteSpor + voteTekn));
            Console.WriteLine("Teknoloji oyu: " + voteTekn + " yüzde: " + voteFilm / (voteFilm + voteSpor + voteTekn));
            Console.WriteLine("Spor oyu: " + voteSpor + " yüzde: " + voteFilm / (voteFilm + voteSpor + voteTekn));
            Console.ReadKey();
        }
    }
}
