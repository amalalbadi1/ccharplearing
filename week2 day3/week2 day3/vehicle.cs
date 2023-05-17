using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3
{
     class vehicle
    {
        public int id;
        public string name;
        public string description;

        public vehicle(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

       
    }
    interface Ilode
    {
        void load();

        void unlod();
    }

    interface IDivable
    {

        void move();

        void stop();
    }


    class Honda : vehicle , IDivable
    { 
        public int yearof;

        public Honda(int id, string name, string description, int yearof) : base(id, name, description)
        {
            this.yearof = yearof;
        }
         
        public void move()
        {
            Console.WriteLine(" moving");
        }

        public void stop()
        {
            Console.WriteLine("stoping");
        }
    }

    class caterpill : vehicle, IDivable
    {
        public int yearof;

        public caterpill(int id, string name, string description, int yearof) : base(id, name, description)
        {
            this.yearof = yearof;
        }
        public void move()
        {
            Console.WriteLine(" moving");
        }

        public void stop()
        {
            Console.WriteLine("stoping");
        }
    }
}
