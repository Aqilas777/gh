using System;

namespace if_if_else
{
    class Program
    {
        static void Main(string[] args)
        {


            //int semestr1;
            //Console.WriteLine("1 ci semestr balini daxil edin");
            //semestr1 = int.Parse(Console.ReadLine());

            //int semestr2;
            //Console.WriteLine("2 ci semestr balini daxil edin");
            //semestr2 = int.Parse(Console.ReadLine());

            //int sum = semestr1 + semestr2;

            //birinci semestirda eger 20 den asagi bal alibsa siz imtahadan kesildiniz yazisini yazdira
            //    bilmire.ikinci defe semest2 ni soruwur menden halbu ki 1 cini asagi yaziram yenede
            //    2 ci semestr cavabini isdeyir

            //if (semestr1 < 20)
            //{
            //    Console.WriteLine("Imtahadan kesildiniz");
            //}

            //else if (sum <= 60)
            //{
            //    Console.WriteLine("Imtahandan kesildiniz");
            //}
            //else
            //{
            //    Console.WriteLine("{0}  Bal ile Imtahadan kecdiniz",sum);
            //}


            //ededin ortalamasini tapir
            //int number;
            //int sum = 0;
            //int avreage;

            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("{0}.Ededi daxil edin",i);
            //    number = int.Parse(Console.ReadLine());
            //    sum += number;
            //}
            //avreage = sum / 3;
            //Console.WriteLine("Ortalama {0}",avreage);

            //int number = 0;
            //for (int i = 1; i <= 6; i++)
            //{
            //    Console.Write("{0}. Ededi daxil edin ", i);
            //    number = int.Parse(Console.ReadLine());
            //    if (number > 0)
            //    {
            //        Console.WriteLine("Musbet");
            //    }
            //    else if (number < 0)
            //    {
            //        Console.WriteLine("Menfi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sifir");
            //    }
            //}


            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.SetCursorPosition(6, i);
            //    Console.WriteLine("*");

            //}



            //Console.WriteLine("Enini daxil edin");
            //double ei = double.Parse(Console.ReadLine());

            //Console.WriteLine("Uzununu daxil edin");
            //double uu = double.Parse(Console.ReadLine());
            //double dikdortgenalan = alancevresihesapla.alaniHesapla(ei, uu);
            //double dikdortkencevre = alancevresihesapla.cevreniHesapla(ei, uu);
            //Console.WriteLine("Dikdortgen alan:{0} Dikdortgen cevre: {1}",dikdortgenalan,dikdortkencevre);
            
            Console.WriteLine("Isidfadeci adini daxil edin");
            string kadi = Console.ReadLine();

            Console.WriteLine("Parolu daxil edin");
            string sifre = Console.ReadLine();

            kontrolet(kadi, sifre);

        }

        static public void kontrolet(string username,string password)
        {
            if(username=="aqil"&& password == "aqil312")
            {
                Console.WriteLine("Adi ve Sifreni dogru daxil etdiniz");
            }
            else
            {
                Console.WriteLine("Giris bawarisiz");
            }
        }

    }
    //class alancevresihesapla
    //{
    //    public static double alaniHesapla(double eni,double uzunu)
    //    {
    //        double alan = eni * uzunu;
    //        return alan;

    //    }
    //    public static double cevreniHesapla(double eni,double uzunu)
    //    {
    //        double cevre = 2 * (eni + uzunu);
    //            return cevre;
    //    }
    //}
}
