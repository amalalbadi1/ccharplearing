
namespace week3_day4_event
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weather wea = new Weather(23);
            wea.Onweatherchang += Wea_Onweatherchang;
            wea.weatherchang(29);

        }

        private static void Wea_Onweatherchang(Weather w)
        {
            if (w.Temprature < 17)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"rain and cold");
            }
            else if (w.Temprature > 17 && w.Temprature < 25)
            {
                Console.WriteLine($"cloud no rain");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hot and melt");
            }
        }
    }

    class Weather
    {
        private int temprature;
        private string condition;

        public int Temprature { get => this.temprature; set => this.temprature = value; }
        public string Condition => this.condition;

        public Weather(int Temprature)
        {
            this.Temprature = Temprature;
        }

        public delegate void weatherChange(Weather w);
        public event weatherChange Onweatherchang;

        public void weatherchang(int temprature)
        {
            
            this.temprature += temprature;


            if (Onweatherchang != null)
            {
                Onweatherchang(this);
            }


        }
    }





}



