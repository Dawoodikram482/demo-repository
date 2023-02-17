namespace assignment2_week2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }
        void Start()
        {
            PrintMonths();
            Month month = ReadMonth("Enter a number:");
            PrintMonth(month);
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
                Console.WriteLine($"{string.Format("{0, 3}", number)} {month}");
            }
        }
        Month ReadMonth(string question)
        {
            Console.WriteLine(question);
            int monthNumber = int.Parse(Console.ReadLine());
            Month month = (Month)(monthNumber);
            while (!Enum.IsDefined(typeof(Month), month))
            {
                Console.WriteLine($"{monthNumber} is invalid!");
                Console.WriteLine(question);
                month = (Month)(monthNumber);
            }
            return month;

        }

       
    }
}