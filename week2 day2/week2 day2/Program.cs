namespace week2_day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Person p1 = new Person();
            p1.setfname("amal");
            p1.setlname("albadi");
            p1.setage(1);
            p1.setSalary(20);
            p1.setrelationshipStatues("fghj");
            p1.printInfo();

           

            
            int d = 1997;
            int e = 2023;
            Console.WriteLine(p1.age2(e, d));
            */
            
            Bankaccount bank = new Bankaccount("fghjk");
            //Console.WriteLine(bank.deposite( balance, amount));

            bank.deposite(1000);
            bank.deposite(20);
            bank.withdraw(60);
            bank.withdraw(1000);
        }
    }
}