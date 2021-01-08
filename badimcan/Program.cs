using System;

namespace badimcan
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowFullName("resul", "ceferli");

            //double urun1, urun2, ilktoplam, odemetutari, indirim;
            //Console.Write("Birinci ürünün fiyatını girin:");
            //urun1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("İkinci ürünün fiyatını girin:");
            //urun2 = Convert.ToDouble(Console.ReadLine());
            //ilktoplam = urun1 + urun2;
            //odemetutari = ilktoplam;
            //if (ilktoplam >= 200)
            //{
            //    indirim = urun2 * 25 / 100;
            //    odemetutari = ilktoplam - indirim;
            //}
            //Console.WriteLine("Ödeme tutarı:" + odemetutari);


            //double mal1;
            //double mal2;
            //double ilktoplam;
            //double toplamodeme;
            //double endirim;
            //Console.WriteLine("mal1 daxil et");
            //mal1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("mal2 daxil et");
            //ilktoplam = mal1 + mal2;
            //toplamodeme = ilktoplam;
            //if (ilktoplam > 0)
            //{
            //    endirim = ilktoplam * 25 / 100;
            //    toplamodeme = ilktoplam - endirim;
            //}
            //Console.WriteLine("toplam mebleg{0} AZN dir", toplamodeme);


            int x = 10;
            int y = 3;
            int sum;

            sum = x + y;
            Console.WriteLine(sum);


            #region IsdedinilenEdedinVurmasi
            //int i = 1;
            //int sum;
            //int n;
            //Console.WriteLine("n ededi daxil edin");
            //n = Convert.ToInt32(Console.ReadLine());

            //do
            //{
            //    sum = n * i;
            //    Console.WriteLine("{0} * {1} = {2}", n, i, sum);
            //    i++;
            //} while (i <= 10);

            #endregion

            #region SekkizinVurmasi
            //int i = 1, n = 8, product;

            //do
            //{
            //    product = n * i;
            //    Console.WriteLine("{0} * {1} = {2}", n, i, product);
            //    i++;
            //} while (i <= 10);

            #endregion

            #region CalcOperator
            //    int x, y;
            //    string xStr, yStr;
            //    string CalacOperator;
            //    do
            //    {

            //        Console.WriteLine("X ededini daxil edin");
            //        xStr = Console.ReadLine();

            //        Console.WriteLine("Y ededini daxil");
            //        yStr = Console.ReadLine();

            //    } while (!(int.TryParse(xStr, out x) && int.TryParse(yStr, out y)));


            //enterOprator:

            //    Console.WriteLine("Opeartoru daxil edin");
            //    CalacOperator = Console.ReadLine();



            //    int result;

            //    switch (CalacOperator)
            //    {
            //        case "+":
            //            result = x + y;
            //            break;

            //        case "-":
            //            result = x - y;
            //            break;

            //        case "*":
            //            result = x * y;
            //            break;

            //        case "/":
            //            result = x / y;
            //            break;
            //        default:
            //            goto enterOprator;
            //    }

            //    Console.WriteLine($"{x}{CalacOperator}{y}={result}");

            #endregion



            #region MnenNeKimi
            //int M;
            //string mStr;
            //do
            //{
            //    Console.WriteLine("m ededini daxil edin");
            //    mStr = Console.ReadLine();
            //} while (!int.TryParse(mStr, out M));

            //int N;
            //string nStr;
            //do
            //{
            //    Console.WriteLine("n ededini daxil edin");
            //    nStr = Console.ReadLine();
            //} while (!int.TryParse(nStr, out N));

            //bool checkPrime = true;
            //int counter = 0;

            //for (int i = M; i < N; i++)
            //{
            //    for (int j = 2; j < i / 2; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            checkPrime = false;
            //            break;
            //        }
            //    }
            //    if (checkPrime && i != 1)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);
            #endregion


            //int i = 1, sum = 0;

            //while (i <= 5)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Sum = {0}", sum);

            //int i = 0;

            //while (i < 200)
            //{
            //    Console.WriteLine("i = {0}", i);
            //    i++;
            //}

            //for (int i = 10; i>0; i--)
            //{
            //    Console.WriteLine("Value of i: {0}", i);
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = i; j < 4; j++)
            //        Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            //


            #region MyForIle
            //int number = 0;
            //int sum = 0;
            //int amount = 0;
            //while (amount < 10)
            //{
            //    Console.WriteLine("number:");
            //    number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    amount++;
            //}
            #endregion



            #region MyWhileIle
            //int toplam = 0;

            //for (long i = 1; i <= 10; i++)
            //{
            //    Console.Write(i.ToString() + ". sayı: ");
            //    int a = int.Parse(Console.ReadLine());
            //    toplam += a;
            //}

            //Console.WriteLine("Toplam: " + toplam.ToString());
            #endregion

            //int amount = 0;

            //for (long i = 1; i <= 10; i++)
            //{
            //    Console.Write(i.ToString() + ". eded:");
            //    int a = int.Parse(Console.ReadLine());
            //    if (a % 2 == 0) 
            //        amount++;
            //}

            //Console.WriteLine(amount.ToString() + " eded cut reqem daxil oldunuz");

            //string name = Console.ReadLine();
            //string surname = Console.ReadLine();

            //string fullName = GetFullName(name, surname);

        }

        //static void ShowFullName(string name, string surname)
        //{
        //    string fullName = name + " " + surname;
        //    Console.WriteLine(fullName);
        //}

        //static string GetFullName(string name,string surname)
        //{
        //    string fullName = name + " " + surname;
        //    return fullName;
        //}


    }
}
