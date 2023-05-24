namespace week3_day2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] emps = new employee[]
            {
                new employee { id = 1, name = "amal", genter = 'm', salare = 444m },
                new employee { id = 2, name = "misa", genter = 'm', salare = 6666m },
                new employee { id = 3, name = "amani", genter = 'f', salare = 555m },
                new employee { id = 4, name = "asma", genter = 'f', salare = 477777744m },
                new employee { id = 5, name = "hoor", genter = 'm', salare = 6666m },
            };

            Report report = new Report();
            report.prossisEmployee(emps, "tatal salare >600", (emps) => emps.salare >600m);
            report.prossisEmployee(emps, "tatal salare betwen600 and 300 ", (emps) => emps.salare>600m && emps.salare > 300m);
            report.prossisEmployee(emps, "tatal<300", (emps) => emps.salare <300m);
        }
    }
}