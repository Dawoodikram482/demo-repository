namespace assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 10);
            while (number != 0)
            {
                int factorial = Factorial(number);
                Console.WriteLine($"Factorial of {number} is {factorial}");

                number = random.Next(0, 10);
            }
            Console.WriteLine();
            Console.WriteLine("End of program");
        }
        static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}