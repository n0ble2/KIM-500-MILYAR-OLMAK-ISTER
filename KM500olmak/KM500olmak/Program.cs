using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KM500olmak
{

    internal class Program
    {                            // sql // no sql 2 tip vardır.
        public class Soru
        {
            public string Sorumuz;
            public List<Cevap> CevapListesi;
        }
        public class Cevap
        {
            public string sik;
        }

        class Jok
        {
            public static int First;
            public static int Second;
            public static string b;
        }

        static void Main(string[] args)
        {
            Jok.First = 0;
            Jok.Second = 0;
            Jok.b = "y";

            int FirstAnswer = 0;
            string a = Convert.ToString(FirstAnswer);

            List<Soru> SoruListesi1 = new List<Soru>();
            List<Soru> SoruListesi2 = new List<Soru>();
            List<Soru> SoruListesi3 = new List<Soru>();
            List<Soru> SoruListesi4 = new List<Soru>();
            List<Soru> SoruListesi5 = new List<Soru>();

            Soru Soru1 = new Soru();
            Cevap Cevap11 = new Cevap();
            Cevap Cevap12 = new Cevap();
            Cevap Cevap13 = new Cevap();
            Cevap Cevap14 = new Cevap();


            Soru Soru2 = new Soru();
            Cevap Cevap21 = new Cevap();
            Cevap Cevap22 = new Cevap();
            Cevap Cevap23 = new Cevap();
            Cevap Cevap24 = new Cevap();
            Cevap Joker21 = new Cevap();
            Cevap Joker22 = new Cevap();

            Soru Soru3 = new Soru();
            Cevap Cevap31 = new Cevap();
            Cevap Cevap32 = new Cevap();
            Cevap Cevap33 = new Cevap();
            Cevap Cevap34 = new Cevap();
            Cevap Joker31 = new Cevap();
            Cevap Joker32 = new Cevap();

            Soru Soru4 = new Soru();
            Cevap Cevap41 = new Cevap();
            Cevap Cevap42 = new Cevap();
            Cevap Cevap43 = new Cevap();
            Cevap Cevap44 = new Cevap();
            Cevap Joker41 = new Cevap();
            Cevap Joker42 = new Cevap();

            Soru Soru5 = new Soru();
            Cevap Cevap51 = new Cevap();
            Cevap Cevap52 = new Cevap();
            Cevap Cevap53 = new Cevap();

            Cevap Cevap54 = new Cevap();
            Cevap Joker51 = new Cevap();
            Cevap Joker52 = new Cevap();

            Soru1.CevapListesi = new List<Cevap>();
            Soru2.CevapListesi = new List<Cevap>();
            Soru3.CevapListesi = new List<Cevap>();
            Soru4.CevapListesi = new List<Cevap>();
            Soru5.CevapListesi = new List<Cevap>();


            Start();
            Console.ReadLine();

            void Start()
            {

            Back:

                Console.WriteLine("OYUNUMUZA HOŞGELDİNİZ!");
                Console.WriteLine("----------------------");

                Console.WriteLine("[1] Oyuna başla");
                Console.WriteLine("[2] Kurallar");
                Console.WriteLine("[3] Çıkış");
                Console.Write("\r\n\r\nLütfen Girmek İstediğiniz Bölüm Numarasını Tuşlayınız ==>");

                string UserValue = Console.ReadLine();

                switch (UserValue)
                {
                    case "1":
                        Console.Clear();
                        Q1();
                        break;

                    case "2":
                        Console.Clear();
                        Rules();
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Hatalı işlem yaptınız...");
                        goto Back;


                }

            }

            void Rules()
            {
            BackR:
                Console.Clear();
                Console.WriteLine("KURALLAR");
                Console.WriteLine("--------");
                Console.WriteLine("·Süre sınırı yoktur.İstediğiniz kadar düşünebilirsiniz.");
                Console.WriteLine("·Yanlış yaptığınız taktirde oyununuz sonlanır.");
                Console.WriteLine("·Cevaplamalarınızı küçük harfle yapınız.. [ Yoksa hata verir :) ] ");
                Console.WriteLine("\r\n·Menüye dönemk için lütfen [0]'a basınız.");
                string BackToMenu = Console.ReadLine();

                switch (BackToMenu)
                {
                    case "0":
                        Console.Clear();
                        Start();
                        break;

                    default:
                        Console.WriteLine("Hatalı işlem yaptınız...");
                        goto BackR;
                }
            }

            void Q1()
            {
                Soru1.Sorumuz = "Aşağıdakilerden Hangisi Türkiye'nin Başkentidir?";
                Cevap11.sik = "A) ADANA";
                Cevap12.sik = "B) İSTANBUL";
                Cevap13.sik = "C) ANKARA";
                Cevap14.sik = "D) İZMİR";

                Soru1.CevapListesi.Add(Cevap11);
                Soru1.CevapListesi.Add(Cevap12);
                Soru1.CevapListesi.Add(Cevap13);
                Soru1.CevapListesi.Add(Cevap14);
  

                SoruListesi1.Add(Soru1);

                foreach (Soru ZSoru in SoruListesi1)
                {
                    Console.WriteLine(ZSoru.Sorumuz);



                }
                foreach (var ZCevap in Soru1.CevapListesi)
                {
                    Console.WriteLine(ZCevap.sik);
                }
               

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Çift Cevap Jokeri: [x] - Yarı Yarıya Jokeri: [z]");

                doon:
                Console.Write("\r\n\r\n\r\nLütfen cevabı yazınız ==>");

                a = Console.ReadLine();

                if (a == "z" && Jok.First == 1)
                {
                    Jok.First = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Joker kullandınız ve tekrar kullanamazsınız...");

                }

                if (a == "x" && Jok.Second == 1)
                {
                    Jok.Second = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Jokeri kullandınız ve tekrar kullanamazsınız...");
                    Console.CursorTop = 8;
                    Console.CursorLeft = 0;
                } //çift cevap:x yarı yarıya:z

                if (a == "x" && Jok.Second == 0)
                {
                    Jok.Second = 1;
                hata:
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Çift Cevap Etkinleştirildi...                                                  ");
                no:
                    Console.Write("\r\n\r\n\r\n\r\n\r\nLütfen cevabı yazınız ==>");
                    Jok.b = Console.ReadLine();

                    switch (Jok.b)
                    {
                        case "z":
                            Console.WriteLine("Jokerinizi kullandıktan sonra diğer jokeri kullanabilirsiniz...");
                            Console.CursorTop = 6;
                            Console.CursorLeft = 0;
                            goto no;

                        case "a":
                            Console.CursorTop = 1;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n\r\n\r\n");
                            goto doon;
                        case "b":
                            Console.CursorTop = 2;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n\r\n");
                            goto doon;
                        case "d":
                            Console.CursorTop = 4;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n");
                            goto doon;
                        case "c":
                            Console.Clear();
                        BackH:
                            Console.WriteLine("Cevabınız doğru!            Kazancınız ==> 20.000TL");
                            Console.WriteLine("SONRAKİ SORU: Halo Infinite ne zaman çıktı?");
                            Console.WriteLine("");
                            Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                            Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                            string FirstTrueSolution = Console.ReadLine();
                            switch (FirstTrueSolution)
                            {
                                case "1":
                                    Console.Clear();
                                    Q2();
                                    break;

                                case "2":
                                    Console.Clear();
                                don:
                                    Console.WriteLine("KAZANCINIZ ==> 20.000TL");
                                    Console.WriteLine("");
                                    Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                    string uservalue = Console.ReadLine();
                                    switch (uservalue)
                                    {
                                        case "5":
                                            Console.Clear();
                                            Environment.Exit(0);
                                            break;

                                        default:
                                            Console.Clear();
                                            goto don;
                                    }
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.Clear();
                                    goto BackH;
                                    //Console.WriteLine("Hatalı işlem yaptınız...");
                                    //break;
                            }
                            break;
                        default:
                            goto hata;
                            //break;
                    }
                }

                if (a == "z" && Jok.First == 0)
                {

                    if (Jok.Second == 1 && Jok.b == "b")
                    {
                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "a")
                    {
                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "d")
                    {
                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.First == 0)
                    {
                        Jok.First = 1;

                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }
                }

                if (a != "a" && a != "b" && a != "c" && a != "d")
                {
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("\r\n\r\n");
                    goto doon;
                }

                switch (a)
                {

                    case "x":

                        break;

                    case "z":

                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("1. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                    case "c":
                    BackH:
                        Console.Clear();
                        Console.WriteLine("\r\nCevabınız doğru!            Kazancınız ==> 20.000TL");
                        Console.WriteLine("SONRAKİ SORU: Halo Infinite ne zaman çıktı?");
                        Console.WriteLine("");
                        Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                        Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                        string FirstTrueSolution = Console.ReadLine();
                        switch (FirstTrueSolution)
                        {
                            case "1":
                                Console.Clear();
                                Q2();
                                break;

                            case "2":
                                Console.Clear();
                            don:
                                Console.WriteLine("KAZANCINIZ ==> 20.000TL");
                                Console.WriteLine("");
                                Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                string uservalue = Console.ReadLine();
                                switch (uservalue)
                                {
                                    case "5":
                                        Console.Clear();
                                        Environment.Exit(0);
                                        break;

                                    default:
                                        Console.Clear();
                                        goto don;
                                }
                                Console.ReadLine();
                                break;
                            default:
                                Console.Clear();

                                goto BackH;
                        }
                        break;

                    case "b":
                        Console.Clear();
                        Console.WriteLine("1. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case "d":
                        Console.Clear();
                        Console.WriteLine("1. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    default:

                        Console.CursorTop = 5;
                        Console.CursorLeft = 0;
                        Console.WriteLine("Hatalı işlem...");
                        goto doon;
                }

                Console.ReadLine();
            }

            void Q2()
            {
                Soru2.Sorumuz = "Halo Infinite ne zaman çıktı?";
                Cevap21.sik = "A) 2018";
                Cevap22.sik = "B) 2019";
                Cevap23.sik = "C) 2020";
                Cevap24.sik = "D) 2021";

                Soru2.CevapListesi.Add(Cevap21);
                Soru2.CevapListesi.Add(Cevap22);
                Soru2.CevapListesi.Add(Cevap23);
                Soru2.CevapListesi.Add(Cevap24);

                SoruListesi2.Add(Soru2);


                foreach (Soru ZSoru in SoruListesi2)
                {
                    Console.WriteLine(ZSoru.Sorumuz);
                }
                foreach (var ZCevap in Soru2.CevapListesi)
                {
                    Console.WriteLine(ZCevap.sik);
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Yarı Yarıya Jokeri: [z] - Çift Cevap Jokeri: [x]");

            doon:
                Console.Write("\r\n\r\n\r\nLütfen cevabı yazınız ==>");

                a = Console.ReadLine();

                if (a == "z" && Jok.First == 1)
                {
                    Jok.First = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Joker kullandınız ve tekrar kullanamazsınız...");

                }

                if (a == "x" && Jok.Second == 1)
                {
                    Jok.Second = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Jokeri kullandınız ve tekrar kullanamazsınız...");
                    Console.CursorTop = 8;
                    Console.CursorLeft = 0;
                }

                if (a == "x" && Jok.Second == 0)
                {
                    Jok.Second = 1;
                hata:
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Çift Cevap Etkinleştirildi...                                                  ");
                no:
                    Console.Write("\r\n\r\n\r\n\r\n\r\nLütfen cevabı yazınız ==>");
                    Jok.b = Console.ReadLine();

                    switch (Jok.b)
                    {
                        case "z":
                            Console.WriteLine("Jokerinizi kullandıktan sonra diğer jokeri kullanabilirsiniz...");
                            Console.CursorTop = 6;
                            Console.CursorLeft = 0;
                            goto no;

                        case "a":
                            Console.CursorTop = 1;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n\r\n\r\n");
                            goto doon;
                        case "b":
                            Console.CursorTop = 2;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n\r\n");
                            goto doon;
                        case "c":
                            Console.CursorTop = 3;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n");
                            goto doon;
                        case "d":
                            Console.Clear();
                        BackH:
                            Console.WriteLine("Cevabınız doğru!            Kazancınız ==> 50.000TL");
                            Console.WriteLine("SONRAKİ SORU: Beşiktaş hangi tarihte kuruldu?");
                            Console.WriteLine("");
                            Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                            Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                            string FirstTrueSolution = Console.ReadLine();
                            switch (FirstTrueSolution)
                            {
                                case "1":
                                    Console.Clear();
                                    Q3();
                                    break;

                                case "2":
                                    Console.Clear();
                                don:
                                    Console.WriteLine("KAZANCINIZ ==> 50.000TL");
                                    Console.WriteLine("");
                                    Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                    string uservalue = Console.ReadLine();
                                    switch (uservalue)
                                    {
                                        case "5":
                                            Console.Clear();
                                            Environment.Exit(0);
                                            break;

                                        default:
                                            Console.Clear();
                                            goto don;
                                    }
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.Clear();
                                    goto BackH;
                                    //Console.WriteLine("Hatalı işlem yaptınız...");
                                    //break;
                            }
                            break;
                         default:
                            goto hata;
                            //break;
                    }
                }

                if (a == "z" && Jok.First == 0)
                {

                    if (Jok.Second == 1 && Jok.b == "b")
                    {
                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "a")
                    {
                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "c")
                    {
                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.First == 0)
                    {
                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Jok.First = 1;

                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }
                }

                if (a != "a" && a != "b" && a != "c" && a != "d")
                {
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("\r\n\r\n");
                    goto doon;
                }

                switch (a)
                {

                    case "x":

                        break;

                    case "z":

                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("2. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                    case "d":
                    BackH:
                        Console.Clear();
                        Console.WriteLine("\r\nCevabınız doğru!            Kazancınız ==> 50.000TL");
                        Console.WriteLine("SONRAKİ SORU: Beşiktaş hangi tarihte kuruldu?");
                        Console.WriteLine("");
                        Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                        Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                        string FirstTrueSolution = Console.ReadLine();
                        switch (FirstTrueSolution)
                        {
                            case "1":
                                Console.Clear();
                                Q3();
                                break;

                            case "2":
                                Console.Clear();
                            don:
                                Console.WriteLine("KAZANCINIZ ==> 50.000TL");
                                Console.WriteLine("");
                                Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                string uservalue = Console.ReadLine();
                                switch (uservalue)
                                {
                                    case "5":
                                        Console.Clear();
                                        Environment.Exit(0);
                                        break;

                                    default:
                                        Console.Clear();
                                        goto don;
                                }
                                Console.ReadLine();
                                break;
                            default:
                                Console.Clear();

                                goto BackH;
                        }
                        break;

                    case "b":
                        Console.Clear();
                        Console.WriteLine("2. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("2. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    default:

                        Console.CursorTop = 5;
                        Console.CursorLeft = 0;
                        Console.WriteLine("Hatalı işlem...");
                        goto doon;
                }

                Console.ReadLine();
            }

            void Q3()
            {
                Soru3.Sorumuz = "Fenerbahçe ne zaman kuruldu?";
                Cevap31.sik = "A) 1906";
                Cevap32.sik = "B) 1907";
                Cevap33.sik = "C) 1908";
                Cevap34.sik = "D) 1909";

                Soru3.CevapListesi.Add(Cevap31);
                Soru3.CevapListesi.Add(Cevap32);
                Soru3.CevapListesi.Add(Cevap33);
                Soru3.CevapListesi.Add(Cevap34);

                SoruListesi3.Add(Soru3);


                foreach (Soru ZSoru in SoruListesi3)
                {
                    Console.WriteLine(ZSoru.Sorumuz);
                }
                foreach (var ZCevap in Soru3.CevapListesi)
                {
                    Console.WriteLine(ZCevap.sik);
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Yarı Yarıya Jokeri: [z] - Çift Cevap Jokeri: [x]");

            doon:
                Console.Write("\r\n\r\n\r\nLütfen cevabı yazınız ==>");

                a = Console.ReadLine();

                if (a == "z" && Jok.First == 1)
                {
                    Jok.First = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Joker kullandınız ve tekrar kullanamazsınız...");

                }

                if (a == "x" && Jok.Second == 1)
                {
                    Jok.Second = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Jokeri kullandınız ve tekrar kullanamazsınız...");
                    Console.CursorTop = 8;
                    Console.CursorLeft = 0;
                }

                if (a == "x" && Jok.Second == 0)
                {
                    Jok.Second = 1;
                hata:
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Çift Cevap Etkinleştirildi...                                                  ");
                no:
                    Console.Write("\r\n\r\n\r\n\r\n\r\nLütfen cevabı yazınız ==>");
                    Jok.b = Console.ReadLine();

                    switch (Jok.b)
                    {
                        case "z":
                            Console.WriteLine("Jokerinizi kullandıktan sonra diğer jokeri kullanabilirsiniz...");
                            Console.CursorTop = 6;
                            Console.CursorLeft = 0;
                            goto no;

                        case "a":
                            Console.CursorTop = 1;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n\r\n\r\n");
                            goto doon;
                        case "d":
                            Console.CursorTop = 4;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n");
                            goto doon;
                        case "c":
                            Console.CursorTop = 3;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n");
                            goto doon;
                        case "b":
                            Console.Clear();
                        BackH:
                            Console.WriteLine("Cevabınız doğru!            Kazancınız ==> 100.000TL");
                            Console.WriteLine("SONRAKİ SORU: Beşiktaş hangi tarihte kuruldu?");
                            Console.WriteLine("");
                            Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                            Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                            string FirstTrueSolution = Console.ReadLine();
                            switch (FirstTrueSolution)
                            {
                                case "1":
                                    Console.Clear();
                                    Q4();
                                    break;

                                case "2":
                                    Console.Clear();
                                don:
                                    Console.WriteLine("KAZANCINIZ ==> 50.000TL");
                                    Console.WriteLine("");
                                    Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                    string uservalue = Console.ReadLine();
                                    switch (uservalue)
                                    {
                                        case "5":
                                            Console.Clear();
                                            Environment.Exit(0);
                                            break;

                                        default:
                                            Console.Clear();
                                            goto don;
                                    }
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.Clear();
                                    goto BackH;
                                    //Console.WriteLine("Hatalı işlem yaptınız...");
                                    //break;
                            }
                            break;
                        default:
                            goto hata;
                            //break;
                    }
                }

                if (a == "z" && Jok.First == 0)
                {

                    if (Jok.Second == 1 && Jok.b == "d")
                    {
                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "a")
                    {
                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "c")
                    {
                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.First == 0)
                    {
                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Jok.First = 1;

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }
                }

                if (a != "a" && a != "b" && a != "c" && a != "d")
                {
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("\r\n\r\n");
                    goto doon;
                }

                switch (a)
                {

                    case "x":

                        break;

                    case "z":

                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                    case "b":
                    BackH:
                        Console.Clear();
                        Console.WriteLine("\r\nCevabınız doğru!            Kazancınız ==> 100.000TL");
                        Console.WriteLine("SONRAKİ SORU: LOREM IPSUM LOREM?");
                        Console.WriteLine("");
                        Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                        Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                        string FirstTrueSolution = Console.ReadLine();
                        switch (FirstTrueSolution)
                        {
                            case "1":
                                Console.Clear();
                                Q4();
                                break;

                            case "2":
                                Console.Clear();
                            don:
                                Console.WriteLine("KAZANCINIZ ==> 100.000TL");
                                Console.WriteLine("");
                                Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                string uservalue = Console.ReadLine();
                                switch (uservalue)
                                {
                                    case "5":
                                        Console.Clear();
                                        Environment.Exit(0);
                                        break;

                                    default:
                                        Console.Clear();
                                        goto don;
                                }
                                Console.ReadLine();
                                break;
                            default:
                                Console.Clear();

                                goto BackH;
                        }
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    default:

                        Console.CursorTop = 5;
                        Console.CursorLeft = 0;
                        Console.WriteLine("Hatalı işlem...");
                        goto doon;
                }

                Console.ReadLine();
            }

            void Q4()
            {
                Soru4.Sorumuz = "LOREM IPSUM SOLAR VOID? (SORU BULAMADIM KEKW)";
                Cevap41.sik = "A) DOĞRU";
                Cevap42.sik = "B) YANLIŞ";
                Cevap43.sik = "C) YANLIŞ";
                Cevap44.sik = "D) YANLIŞ";

                Soru4.CevapListesi.Add(Cevap41);
                Soru4.CevapListesi.Add(Cevap42);
                Soru4.CevapListesi.Add(Cevap43);
                Soru4.CevapListesi.Add(Cevap44);

                SoruListesi4.Add(Soru4);


                foreach (Soru ZSoru in SoruListesi4)
                {
                    Console.WriteLine(ZSoru.Sorumuz);
                }
                foreach (var ZCevap in Soru4.CevapListesi)
                {
                    Console.WriteLine(ZCevap.sik);
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Yarı Yarıya Jokeri: [z] - Çift Cevap Jokeri: [x]");

            doon:
                Console.Write("\r\n\r\n\r\nLütfen cevabı yazınız ==>");

                a = Console.ReadLine();

                if (a == "z" && Jok.First == 1)
                {
                    Jok.First = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Joker kullandınız ve tekrar kullanamazsınız...");

                }

                if (a == "x" && Jok.Second == 1)
                {
                    Jok.Second = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Jokeri kullandınız ve tekrar kullanamazsınız...");
                    Console.CursorTop = 8;
                    Console.CursorLeft = 0;
                }

                if (a == "x" && Jok.Second == 0)
                {
                    Jok.Second = 1;
                hata:
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Çift Cevap Etkinleştirildi...                                                  ");
                no:
                    Console.Write("\r\n\r\n\r\n\r\n\r\nLütfen cevabı yazınız ==>");
                    Jok.b = Console.ReadLine();

                    switch (Jok.b)
                    {
                        case "z":
                            Console.WriteLine("Jokerinizi kullandıktan sonra diğer jokeri kullanabilirsiniz...");
                            Console.CursorTop = 6;
                            Console.CursorLeft = 0;
                            goto no;

                        case "b":
                            Console.CursorTop = 2;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n\r\n");
                            goto doon;
                        case "d":
                            Console.CursorTop = 4;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n");
                            goto doon;
                        case "c":
                            Console.CursorTop = 3;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n");
                            goto doon;
                        case "a":
                            Console.Clear();
                        BackH:
                            Console.WriteLine("Cevabınız doğru!            Kazancınız ==> 250.000TL");
                            Console.WriteLine("SONRAKİ SORU: Beşiktaş hangi tarihte kuruldu?");
                            Console.WriteLine("");
                            Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                            Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                            string FirstTrueSolution = Console.ReadLine();
                            switch (FirstTrueSolution)
                            {
                                case "1":
                                    Console.Clear();
                                    Q5();
                                    break;

                                case "2":
                                    Console.Clear();
                                don:
                                    Console.WriteLine("KAZANCINIZ ==> 250.000TL");
                                    Console.WriteLine("");
                                    Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                    string uservalue = Console.ReadLine();
                                    switch (uservalue)
                                    {
                                        case "5":
                                            Console.Clear();
                                            Environment.Exit(0);
                                            break;

                                        default:
                                            Console.Clear();
                                            goto don;
                                    }
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.Clear();
                                    goto BackH;
                                    //Console.WriteLine("Hatalı işlem yaptınız...");
                                    //break;
                            }
                            break;
                        default:
                            goto hata;
                            //break;
                    }
                }

                if (a == "z" && Jok.First == 0)
                {

                    if (Jok.Second == 1 && Jok.b == "d")
                    {
                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "b")
                    {
                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "c")
                    {
                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.First == 0)
                    {
                        Console.CursorTop = 2;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Jok.First = 1;

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }
                }

                if (a != "a" && a != "b" && a != "c" && a != "d")
                {
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("\r\n\r\n");
                    goto doon;
                }

                switch (a)
                {

                    case "x":

                        break;

                    case "z":

                        break;

                    case "b":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                    case "a":
                    BackH:
                        Console.Clear();
                        Console.WriteLine("\r\nCevabınız doğru!            Kazancınız ==> 250.000TL");
                        Console.WriteLine("SONRAKİ SORU: LOREM IPSUM LOREM?");
                        Console.WriteLine("");
                        Console.WriteLine("\r\nDevam etmek için [1]'e basınız...");
                        Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [2]'ye basınız...");
                        string FirstTrueSolution = Console.ReadLine();
                        switch (FirstTrueSolution)
                        {
                            case "1":
                                Console.Clear();
                                Q5();
                                break;

                            case "2":
                                Console.Clear();
                            don:
                                Console.WriteLine("KAZANCINIZ ==> 250.000TL");
                                Console.WriteLine("");
                                Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                string uservalue = Console.ReadLine();
                                switch (uservalue)
                                {
                                    case "5":
                                        Console.Clear();
                                        Environment.Exit(0);
                                        break;

                                    default:
                                        Console.Clear();
                                        goto don;
                                }
                                Console.ReadLine();
                                break;
                            default:
                                Console.Clear();

                                goto BackH;
                        }
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    default:

                        Console.CursorTop = 5;
                        Console.CursorLeft = 0;
                        Console.WriteLine("Hatalı işlem...");
                        goto doon;
                }

                Console.ReadLine();
            }

            void Q5()
            {
                Soru5.Sorumuz = "DREAMING CITY'nin Kraliçesi kimdir ?";
                Cevap51.sik = "A) QUEEN SAVATHUN";
                Cevap52.sik = "B) QUEEN MARA SOV";
                Cevap53.sik = "C) QUEEN CAYDE 6 :)";
                Cevap54.sik = "D) OUEEN AHSOKA TANO";

                Soru5.CevapListesi.Add(Cevap51);
                Soru5.CevapListesi.Add(Cevap52);
                Soru5.CevapListesi.Add(Cevap53);
                Soru5.CevapListesi.Add(Cevap54);

                SoruListesi5.Add(Soru5);


                foreach (Soru ZSoru in SoruListesi5)
                {
                    Console.WriteLine(ZSoru.Sorumuz);
                }
                foreach (var ZCevap in Soru5.CevapListesi)
                {
                    Console.WriteLine(ZCevap.sik);
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Yarı Yarıya Jokeri: [z] - Çift Cevap Jokeri: [x]");

            doon:
                Console.Write("\r\n\r\n\r\nLütfen cevabı yazınız ==>");

                a = Console.ReadLine();

                if (a == "z" && Jok.First == 1)
                {
                    Jok.First = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Joker kullandınız ve tekrar kullanamazsınız...");

                }

                if (a == "x" && Jok.Second == 1)
                {
                    Jok.Second = 1;
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Jokeri kullandınız ve tekrar kullanamazsınız...");
                    Console.CursorTop = 8;
                    Console.CursorLeft = 0;
                }

                if (a == "x" && Jok.Second == 0)
                {
                    Jok.Second = 1;
                hata:
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("Çift Cevap Etkinleştirildi...                                                  ");
                no:
                    Console.Write("\r\n\r\n\r\n\r\n\r\nLütfen cevabı yazınız ==>");
                    Jok.b = Console.ReadLine();

                    switch (Jok.b)
                    {
                        case "z":
                            Console.WriteLine("Jokerinizi kullandıktan sonra diğer jokeri kullanabilirsiniz...");
                            Console.CursorTop = 6;
                            Console.CursorLeft = 0;
                            goto no;

                        case "a":
                            Console.CursorTop = 1;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n\r\n\r\n\r\n");
                            goto doon;
                        case "d":
                            Console.CursorTop = 4;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n");
                            goto doon;
                        case "c":
                            Console.CursorTop = 3;
                            Console.CursorLeft = 0;
                            Console.WriteLine("Cevabınız yanlış...                                ");
                            Console.WriteLine("\r\n\r\n\r\n");
                            goto doon;
                        case "b":
                            Console.Clear();
                        BackH:
                            Console.WriteLine("Cevabınız doğru!            Kazancınız ==> 500.000TL");
                            Console.WriteLine("TEBRİKLER OYUNU BİTİRDİNİZ...");
                            Console.WriteLine("");
                            Console.WriteLine("\r\n");
                            Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [1]'e basınız...");
                            string FirstTrueSolution = Console.ReadLine();
                            switch (FirstTrueSolution)
                            {
                                case "1":
                                    Console.Clear();
                                don:
                                    Console.WriteLine("KAZANCINIZ ==> 500.000TL");
                                    Console.WriteLine("");
                                    Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                    string uservalue = Console.ReadLine();
                                    switch (uservalue)
                                    {
                                        case "5":
                                            Console.Clear();
                                            Environment.Exit(0);
                                            break;

                                        default:
                                            Console.Clear();
                                            goto don;
                                    }
                                    Console.ReadLine();
                                    break;
                                default:
                                    Console.Clear();
                                    goto BackH;
                                    //Console.WriteLine("Hatalı işlem yaptınız...");
                                    //break;
                            }
                            break;
                        default:
                            goto hata;
                            //break;
                    }
                }

                if (a == "z" && Jok.First == 0)
                {

                    if (Jok.Second == 1 && Jok.b == "d")
                    {
                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "a")
                    {
                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.Second == 1 && Jok.b == "c")
                    {
                        Console.CursorTop = 4;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }

                    if (Jok.First == 0)
                    {
                        Console.CursorTop = 1;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Jok.First = 1;

                        Console.CursorTop = 3;
                        Console.CursorLeft = 0;
                        Console.WriteLine("---------------     ");

                        Console.CursorTop = 7;
                        Console.CursorLeft = 0;
                        Console.WriteLine("");
                        goto doon;
                    }
                }

                if (a != "a" && a != "b" && a != "c" && a != "d")
                {
                    Console.CursorTop = 5;
                    Console.CursorLeft = 0;
                    Console.WriteLine("\r\n\r\n");
                    goto doon;
                }

                switch (a)
                {

                    case "x":

                        break;

                    case "z":

                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);

                        break;
                    case "b":
                    BackH:
                        Console.Clear();
                        Console.WriteLine("\r\nCevabınız doğru!            Kazancınız ==> 500.000TL");
                        Console.WriteLine("TEBRİKLER YARIŞMAYI BİTİRDİNİZ...");
                        Console.WriteLine("");
                        Console.WriteLine("\r\n");
                        Console.WriteLine("Paranızı almak ve yarıştan çekilmek için [1]'ye basınız...");
                        string FirstTrueSolution = Console.ReadLine();
                        switch (FirstTrueSolution)
                        {
                            case "1":
                                Console.Clear();
                            don:
                                Console.WriteLine("KAZANCINIZ ==> 500.000TL");
                                Console.WriteLine("");
                                Console.WriteLine("Oyundan çıkmak için 5'e basınız...");
                                string uservalue = Console.ReadLine();
                                switch (uservalue)
                                {
                                    case "5":
                                        Console.Clear();
                                        Environment.Exit(0);
                                        break;

                                    default:
                                        Console.Clear();
                                        goto don;
                                }
                                Console.ReadLine();
                                break;
                            default:
                                Console.Clear();

                                goto BackH;
                        }
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case "c":
                        Console.Clear();
                        Console.WriteLine("3. Soruda elendiniz...");
                        Console.WriteLine("Cevabınız yanlış!           Oyun sonlandırılıyor!");
                        Console.WriteLine("Çıkmak için iki defa ENTER'a basınız...");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    default:

                        Console.CursorTop = 5;
                        Console.CursorLeft = 0;
                        Console.WriteLine("Hatalı işlem...");
                        goto doon;
                }

                Console.ReadLine();
            }
        }

    }
    }