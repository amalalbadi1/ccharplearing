using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace week_3_day3
{
    internal class Program
    {
        public delegate void Rectangle(double Width, double Height);

        class Rectanglee
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public void Add(double Width, double Height)
            {
                Console.WriteLine($"Addition of {Width} and {Height} is : {Width + Height}");
            }
            
            public void Sub(double Width, double Height)
            {
                Console.WriteLine($"Subtraction of {Width} and {Height} is : {Width - Height}");
            }
           
            public void Mul(double Width, double Height)
            {
                Console.WriteLine($"Multiplication of {Width} and {Height} is : {Width * Height}");
            }
            
            public void Div(double Width, double Height)
            {
                Console.WriteLine($"Division of {Width} and {Height} is : {Width / Height}");
            }
           

}
static void Main(string[] args)
        {
            Rectanglee rect = new Rectanglee();
            Rectangle rect1 = new Rectangle(rect.Add);
            rect1 += rect.Div;  //subcrape
            // rect1 -= rect.Add;
            rect1 += rect.Mul;
            rect1 += rect.Sub;

            rect1(10, 13);

        }
    }
}