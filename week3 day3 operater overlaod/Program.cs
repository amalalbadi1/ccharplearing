using System;

namespace week3_day3_operater_overlaod
{
    internal class Program
    {   
        static void Main(string[] args)
        {
           Moane m1 = new Moane(1);
           Moane m2 = new Moane(2);
            Moane m3 = m1 + m2;
            Moane m4 = m1 * m2;
            Moane m5 = m1 / m2;
            Moane m6 = m1 - m2;
            Console.WriteLine($" add : {m6.mo}");
            Console.WriteLine($" add : {m3.mo}");
            Console.WriteLine($" sub : {m4.mo}" );
            Console.WriteLine($" div :{m5.mo}");


        }
    }
    class Moane
    {
        public decimal mo { get; set; }


        public Moane(decimal mo)
        {
            this.mo = mo;
        }
        public static Moane operator +(Moane mo1, Moane mo2)
        {
            decimal val = mo1.mo + mo2.mo;
            return new Moane(val);
        }
        public static Moane operator *(Moane mo1, Moane mo2)
        {
            decimal val = mo1.mo * mo2.mo;
            return new Moane(val);
        }
        public static Moane operator /(Moane mo1, Moane mo2)
        {
            decimal val = mo1.mo / mo2.mo;
            return new Moane(val);
        }
        public static Moane operator -(Moane mo1, Moane mo2)
        {
            decimal val = mo1.mo - mo2.mo;
            return new Moane(val);
        }


        public static Moane operator <(Moane mo1, Moane mo2) 
        {
           if (Moane mo1 < Moane mo2)
                return true;
           else
                 return false;
        }

    }
}