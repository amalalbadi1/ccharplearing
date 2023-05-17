using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace week2_day3
{
    abstract class anmail // abstract to no objact for class
    {
        public string name;
        public int age;


        
        
        public virtual void  move() //use virtual overlode 
        {
            Console.WriteLine("thi anmail is move ");
        }

        public abstract void makesound();//abstract mathode 


    }

    class Cat : anmail
    {
        public string genter;


        public override string ToString()// override to tostring
        {
           //  return base.ToString();
            return $" cat name is {this.name}";
        }
        public void sound()
        {
            Console.WriteLine("thi cat sound ");
        }

        public override void move() // to chang behaver of class
        {
            base.move();
            Console.WriteLine("woooooo");
        }

        //abstract mathode 
        public override void makesound()
        {
            Console.WriteLine("bbbb");
        }

    }
    class Dog:anmail
    {
        public string catgrate;
        public void sound()
        {
            Console.WriteLine("thi dog sound ");
        }

        public override void makesound()
        {
            Console.WriteLine("hjkl");
        }

    }

   sealed class Eagle : anmail//sealed to inhertins
    {
        public string genter;
        public void flay()
        {
            Console.WriteLine("egl is flay");
        }

        public override void makesound()
        {
            Console.WriteLine("hjkl");
        }
    }

}
