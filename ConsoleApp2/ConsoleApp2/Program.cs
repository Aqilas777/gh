using System;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {


            //int num = 0;
            //while (num < 10)
            //{
            //    Console.WriteLine(num);
            //    num++;
            //}


            //Console.WriteLine("Ededi daxil edin");
            //int num = int.Parse(Console.ReadLine());
            //bool isprime = true;
            //for (int i = 2; i <= Math.Sqrt(num); i++)
            //{
            //    if (num % i == 0)
            //    {
            //        isprime = false;
            //        break;
            //    }
            //}
            //if (isprime)
            //{
            //    Console.WriteLine("Number is Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not Prime");
            //}



            //if (first > second)
            //{
            //    if (first > third)
            //    {

            //        Console.WriteLine("{ 0} is the largest", first);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is the largest", third);

            //    }
            //}
            //else
            //{
            //    if (second > third)
            //    {
            //        Console.WriteLine("{ 0} is the largest", second);

            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is the largest", third);
            //    }
            //}


            //int num1 = 7, num2 = -7, num3 = 27;
            //if (num1 > num2)
            //{
            //    if (num1 > num3)
            //    {
            //        Console.WriteLine("{ 0} is the largest", num1);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{ 0} is the largest", num3);
            //    }
            //}
            //else
            //{
            //    if (num2 > num3)
            //    {
            //        Console.WriteLine("{ 0} is the largest", num2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{ 0} is the largest", num3);
            //    }
            //}
            //=====================================================

            //int x = 40;
            //int y = 20;
            //if (x > y)
            //{
            //    Console.WriteLine("X Y den boyukdur");
            //}



            //int eded = CalcMeth(6);

            //double cedvel = Vurmac(7);

            #region IsdenilenEdedinVurulmasi

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

            #region ForIle
            //int number = 0;
            //int sum = 0;
            //int amount = 0;
            //while (amount < 3)
            //{
            //    Console.WriteLine("number:");
            //    number = int.Parse(Console.ReadLine());
            //    sum += number;
            //    amount++;
            //}
            #endregion


            #region WhileIle
            //int toplam = 0;

            //for (long i = 1; i <= 5; i++)
            //{
            //    Console.Write(i.ToString() + ". sayı: ");
            //    int a = int.Parse(Console.ReadLine());
            //    toplam += a;
            //}

            //Console.WriteLine("Toplam: " + toplam.ToString());
            #endregion

            #region ImtahanDerecesininHesap
            //static char GetGrade()
            //{
            //    float precent = GetPrecentage();

            //    if (precent >= 80)
            //        return 'A';

            //    else if (precent >= 60)
            //        return 'B';

            //    else if (precent >= 40)
            //        return 'C';

            //    else
            //        return 'D';


            //}
            //static float GetPrecentage()
            //{
            //    float totalmarsk = GetTotal();
            //    float precentage = totalmarsk * 100 / 300;
            //    return precentage;
            //}

            //static float GetTotal()
            //{
            //    Console.WriteLine("Enter Marks1");
            //    float marks1 = float.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter Marks2");
            //    float marks2 = float.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter Marsk3");
            //    float marks3 = float.Parse(Console.ReadLine());

            //    float total = marks1 + marks2 + marks3;
            //    return total;

            //    Console.WriteLine("Grade : " + GetGrade());
            //}
            #endregion

        }



        //static int calcMeth()
        //{
        //    int x;
        //    Console.WriteLine("X ededini daxil edin");
        //    x = int.Parse(Console.ReadLine());

        //    int y;
        //    Console.WriteLine("Y ededini daxil edin");
        //    y = int.Parse(Console.ReadLine());

        //    int sum = 0;
        //    sum = x + y;

        //    return sum;

        //    string CalacOperator;
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



        //    }
        //    return x + y;
        //    Console.WriteLine($"{x}{CalacOperator}{y}={result}");
        //}
    }
}