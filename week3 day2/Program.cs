using System.Threading.Channels;

namespace week3_day2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            bool exit = false;

            while (!exit)
            {

                Console.WriteLine("1. Book an appointment");
                Console.WriteLine("2. Update an appointment");

                Console.Write("Enter your choice 1 or 2: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BookAppointment();
                        break;
                    case "2":
                        UpdateAppointment();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                static void BookAppointment()
                {
                    Console.WriteLine("Please choose a day for your appointment:");

                    Console.Write("Enter your choice (1-7): ");

                    string choice = Console.ReadLine();

                    int day;

                   // if (day < 1 || day > 6)
                    {
                        Console.WriteLine("Book an appointment");
                        return;
                    }

                    if (day == 7 || day == 6)
                    {
                        Console.WriteLine("holeday , Please choose another day.");
                        return;
                    }
                }

                static void UpdateAppointment()
                {
                    Console.WriteLine("Update ");

                }
                Day day = Day.Holiday;

                Console.WriteLine(" choos now booking ? ");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"holiday  in this day : {(int)day}");

                Console.WriteLine("enter you name : ");
                Console.ReadLine();

                Console.WriteLine("enter you age : ");
                Console.ReadLine();

                Console.WriteLine(" enter your RelationshipState ");
                Console.ReadLine();

                Console.WriteLine(" enter your FaristVist ");
                Console.ReadLine();
            }
        }
    } }