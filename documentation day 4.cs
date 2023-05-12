using System.Xml.Linq;

namespace day4
{
    internal class Program
    {

        public class Employe
        {

            public const double ATX = 0.03;
            public string fname;
            public string lname;
            public double wage;
            public int loggehaar;
        }

        static void Main(string[] args)
        {
            //input from the user 
            /*
            int employeeNum;
            Console.WriteLine(" Enter the number of employee: ");
            employeeNum = int.Parse(Console.ReadLine());
            */
            Employe emp = new Employe();
            //int[] ints = new int[employeeNum];
            Employe[] emps = new Employe[3];

            foreach (Employe employee in emps)
            {
               

                //input from the user 
                Console.WriteLine("Enter first name: ");
                emp.fname = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                emp.lname = Console.ReadLine();

                Console.WriteLine("Enter number of hours: ");
                emp.loggehaar = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter wage: ");
                emp.wage = int.Parse(Console.ReadLine());

                double netsalare = (emp.wage * emp.wage) - (emp.wage * emp.loggehaar * Employe.ATX);
                // final output
                Console.WriteLine($" full name : {emp.fname}{emp.lname}");
                double tatlsalare = emp.loggehaar * emp.wage;
                double taxrate = emp.loggehaar * Employe.ATX;
                //double netsalare = tatlsalare - taxrate;
                Console.WriteLine($" tatl salare : {tatlsalare}");
                Console.WriteLine($"taxrate : {taxrate}");
                Console.WriteLine($"netsalare : {netsalare}");

            }



        }

    }




        } 
        
    