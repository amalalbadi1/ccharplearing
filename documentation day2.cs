namespace session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //singel array

            int[] arr = new int[3] {1,2,3};
            Console.WriteLine(arr[1]);
            
            ///mlti array
            int[,] mlti = new int[2, 2] ;
            mlti[0,0] = 1;
            mlti[0,1] = 2;
            mlti[1,0] = 3;
            mlti[1,1] = 4;
            Console.WriteLine(mlti[1,1]);

            //jagged array
            int[][] jagg = new int[2][];
            jagg[0]= new int[] { 1, 2, 3 };
            jagg[1]= new int[] { 1, 2 };
            Console.WriteLine(jagg[1][0]); //[index][index]


            //slicing aarray

            int[] nm= new int[] { 1, 2, 3,4,5 };
            int[] slice = nm [1..4];
            int[] slice1 = nm[1..^4];

            Console.WriteLine(nm[0]);
            Console.WriteLine(nm[1]);
            Console.WriteLine(nm[2]);
            Console.WriteLine(nm[3]);

            //add and even
            int a= 3;
            int b=4;
            string add = (a % 2 == 0) ? "x is add":"x is even" ;
            string even = (b % 2 != 0) ? "x is add" : "x is even";
            Console.WriteLine(add);
            Console.WriteLine(even);

            int? z = null;
            Console.WriteLine(z);
            string v = null;
            v = v ?? "amal"; //
            Console.WriteLine(v);


            string m = null;
            Console.WriteLine(m?.ToUpper());


            //Block Statement
            {

                int r = 3;
                Console.WriteLine(r);
            }

            //increment and Decrement 
            {
                int t = 1;
                Console.WriteLine(t++);
                Console.WriteLine(++t);
            }
            a
            if (absenrt>=)
        }
    }
}