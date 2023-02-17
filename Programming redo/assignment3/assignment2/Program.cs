namespace assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                for (int i = 0; i < number; i++)
                {
                    int firstHalfOfNumber = number / 2;
                    if (i < firstHalfOfNumber)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("!");
                    }
                }
                Console.WriteLine("");
                Console.Write("Enter a nummber:");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}