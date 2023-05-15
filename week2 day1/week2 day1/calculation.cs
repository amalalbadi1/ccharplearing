using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day1
{
    internal class calculation

    {
        public int add(int x, int y) => x + y;


        public string add(string x, string y)=>x + y;
        

        public double add (double x, double y)=>x + y;

     public string evenn(int x)=> (x % 2 == 0)? "even" : "odd";
    
    }
}
