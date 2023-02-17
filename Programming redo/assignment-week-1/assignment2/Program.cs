using System.Transactions;

namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program= new Program();
            program.Start();
        }
        void Start()
        {
            PrintMonths();
            Month inputMonth = ReadMonth("Enter a number:");
            PrintMonth(inputMonth);
        }
        void PrintMonth(Month month)
        {
            int monthNumber = (int)month;
            Console.WriteLine($"{monthNumber} => {month}");
        }
        void PrintMonths()
        {
            for (Month month = Month.January; month <= Month.December; month++)
            {
                int number = (int)month;
                Console.WriteLine($"{string.Format("{0, 3}", number)}.{month}");
            }
        }
        Month ReadMonth(string question)
        {
            Console.WriteLine(question);
            int number = int.Parse(Console.ReadLine());
            Month month = (Month)number;
            while (!Enum.IsDefined(typeof(Month), month))
            {
                Console.WriteLine($"{number} is incorrect");
                Console.WriteLine("Enter a number:");
                 number = int.Parse(Console.ReadLine());
                 month = (Month)number;
            }
            return month;
        }
    }
}