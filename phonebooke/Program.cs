namespace phonebooke
{
    internal class Program
    {

        static void Main(string[] args)
        {
            phonebook booke = new phonebook(3);
            booke[0, "amal"] = "12344";
            booke[1, "a"] = "3456";
            booke[2, "b"] = "5678";

            Console.WriteLine( booke["amal"]);
            Console.WriteLine("---------------");

        }
    }
}