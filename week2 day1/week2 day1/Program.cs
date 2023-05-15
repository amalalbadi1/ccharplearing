using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace week2_day1
{
    internal class Program
    {

        /*
        public static void printline(int cnt=5, string pattern="**   ")
        {
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(pattern);
            }
            Console.WriteLine();
        }

        */

        public static void swap(ref int x, ref int y)
        {
            int tmp;
            tmp = x;
            x = y;
            y = tmp;
        }


        public static void SumMul(int x, int y, out int S, out int M)
        {
            S = x + y;
            M = x * y;

        }


     
                   static void Main(string[] args)
        {
            /*
            int x, y, z;
            Console.WriteLine(" enter frist number : ");
            x=int.Parse(Console.ReadLine());
            printline(pattern : "+++  ") ; //use pattern =5 


            
            Console.WriteLine(" enter second number : ");
            x = int.Parse(Console.ReadLine());
            printline(cnt:4 ); //use cnt ** 

            Console.WriteLine();
            */
            //swap
            /*
            int a= 5;
            int b = 7;
            swap(ref a, ref b);
            Console.WriteLine($"a is = {a}");
            Console.WriteLine($"b is ={b}");

            */

            /*
            int a = 3, b = 5, Sresult, Mresult;

            SumMul(a, b, out Sresult, out Mresult);
            Console.WriteLine($"sum :{Sresult}");
            Console.WriteLine($"Multi :{Mresult}");

            */
            /*
            calculation calc = new calculation();
            int a = 10, b = 10;
            
            double c = 6.8, d = 4.7;
            string e = "helo", n = "amal ";
            Console.WriteLine(calc.add(a, b));
            Console.WriteLine(calc.add(c, d));
            Console.WriteLine(calc.add(n, e));
           //onsole.WriteLine(calc.even());
            */


            //this keword
            person p1 = new person(12, "aml", "al badi ", 23, "software engineer ", "muscat");

            
        }
       
    }
}