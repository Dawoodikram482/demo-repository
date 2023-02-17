namespace exam_assignment1
{
    internal class Program
    {
        const double fullYearOneFee = 2209.00;
        const double halfYearOneFee = fullYearOneFee / 2;
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}, is this your first bachelor study?");
            string input = Console.ReadLine();

            if (input == "no")
            {
                Console.WriteLine($"Your college fee for this year is full price ({fullYearOneFee} euros)");
            }

            else if (input == "yes")
            {
                Console.WriteLine("is it a teacher training program?");
                string answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine($"your college fee for first year and second year is ({halfYearOneFee} euros)");
                }
                else if (answer == "no") 
                {
                    Console.WriteLine($"your fee for first year is half ({halfYearOneFee} euros) and full for second year ({fullYearOneFee} euros)");
                }

            }
        }
    }
}