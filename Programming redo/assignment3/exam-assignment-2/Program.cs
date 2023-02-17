namespace exam_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            while (number >= 1)
            {
                int factor = 2;
                while (number > 1)
                {
                    if (number % factor == 0)
                    {
                        number = number / factor;
                        Console.WriteLine($"{factor}");
                    }
                    else
                    {
                        factor++;
                    }
                }
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
            }
        }
    }
}