namespace session3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit type Casting 
            // use Long becuse it is bigger than int so it Can hold it
            int r = 4;
            long z = 5;


            // string to int 
            string a = "7777";

            int b = int.Parse(a);
            Console.WriteLine(b);
            int y = Convert.ToInt32(b);
            int c;
            string m = "12";
            dynamic res =( int.TryParse(m, out c) ? z : "error");
            Console.WriteLine(res);




            //Trying to solve a problem (incomplete)

            int n;
            int x;

            Console.WriteLine("Enter the Number of student : ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks of student : ");
            x = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                if (x <= 59)
                {
                    Console.WriteLine("Grade : F");
                }
                else if (x >= 60 && x <= 69)
                {
                    Console.WriteLine("Grade : D");
                }
                else if (x >= 79 && x <= 79)
                {
                    Console.WriteLine("Grade : C");
                }
                else if (x >= 80 && x <= 89)
                {
                    Console.WriteLine("Grade : B");
                }
                else if (x >= 90 && x <= 10)
                {
                    Console.WriteLine("Grade : B+");
                }

            }
            // Array methods 
            //indexof, sort ,copy and reverse
            int[] num = { 1, 2, 3 };
            int index = Array.IndexOf(num, 2);
            Console.WriteLine(index); 

            
            string[] nam = { "amal", "asma", "hoor"};
            Array.Sort(nam);
            foreach (string name in nam)
            {
                Console.WriteLine(name);
            }


            int[] source = { 1, 2, 3};
            int[] destination = new int[2];
            Array.Copy(source, 1, destination, 0, 3);
            foreach (int number in destination)
            {
                Console.WriteLine(number);
            }

            int[] numbers1 = { 1, 2, 3};
            Array.Reverse(numbers1);
            foreach (int number in numbers1)
            {
                Console.WriteLine(number);
            }
            



            //calculat data
            Console.Write("Enter Radius: ");
            double rad = Convert.ToDouble(Console.ReadLine());
        repeat:
            Console.Write("enter 1 to Area of circle" +
                "enter 2 to Area of circle ");
            double o = Convert.ToDouble(Console.ReadLine());

            
            if (o == 1)
            {
                double area = Math.PI * rad * rad;
                Console.WriteLine("Area of circle is: " + area);
            }

            else if (o == 2)
            {
                double cir = 2 * Math.PI * rad;
                Console.WriteLine("circumference of circle is: " + cir);

            }

            else
            {
                goto repeat;
            }

            
           

        }
    }
}