using System.Diagnostics.Metrics;

namespace week2_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Cat
            Cat cat = new Cat();//object

            cat.name = "rrrrr";
            Console.WriteLine(cat);
            cat.age = 10;
            Console.WriteLine(cat.age);


            cat.move();

            //Dog
            Dog dog = new Dog();

            dog.name = "ddd";
            Console.WriteLine(dog.name);
            dog.age = 4;
            Console.WriteLine(dog.age);


            dog.move();

            //eagle
            Eagle eagle = new Eagle();
            eagle.name = "ddd";
            Console.WriteLine(eagle.name);
            eagle.age = 4;
            Console.WriteLine(eagle.age);

            eagle.genter = "vvvvv";
            Console.WriteLine(eagle.genter);
            eagle.flay();


            eagle.move();

            Honda han = new Honda(12, "ccv", "cvv",77);
            han.move();
            han.stop();

            caterpill ca = new caterpill(55, "gggh", "hhh", 6);
            ca.move();
            ca.stop();


        }
        
    }
}