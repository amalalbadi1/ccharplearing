using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_day2_2
{
    internal class Report
    {



        public delegate bool sels(employee e);


        public void prossisEmployee(employee[] emp, string tital, sels con)
        {

            Console.WriteLine(tital);
            Console.WriteLine("----------------------");
            foreach (employee e in emp)
            {
                if (con(e))
                {

                    Console.WriteLine($"{e.name}|{e.id}| {e.genter}| {e.salare}");
                }
            }
            Console.WriteLine("\n\n");
        }

    }
}
