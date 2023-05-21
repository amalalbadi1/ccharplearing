namespace pymant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            casher cash1 = new casher(new cach(55.5m));
            casher cash2 = new casher(new visa(66.8m));
            casher cash3 = new casher(new Mister(22.4m));
            cash1.chakout();
            cash2.chakout();
            cash3.chakout();
        }
        interface Ipymant
        {
            void pay();
        }
        class casher
        {
            public Ipymant pymant { get; set; }
            public casher (Ipymant pymant)
            {
                this.pymant = pymant;
            }
            public void chakout()
            {
                pymant.pay();
            }

        }
            class cach : Ipymant
            {
                public dynamic amunt { get; set; }

                public cach(dynamic amunt)
                {
                    this.amunt = amunt;
                }
                public void pay()
                {
                    Console.WriteLine($" cach :{amunt} ");
                }
            }

            class visa : Ipymant
            {
                public dynamic amunt { get; set; }

                public visa(dynamic amunt)
                {
                    this.amunt = amunt;
                }
                public void pay()
                {
                    Console.WriteLine($" visa: {amunt} ");
                }
            }
            class Mister : Ipymant
            {
                public dynamic amunt { get; set; }

                public Mister(dynamic amunt)
                {
                    this.amunt = amunt;
                }

                public void pay()
                {
                    Console.WriteLine($"Mister : {amunt} ");
                }
            }
        }
    
}