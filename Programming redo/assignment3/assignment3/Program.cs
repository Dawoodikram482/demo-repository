namespace assignment3
{
    internal class Program
    {
        const int ArrayLength = 20;
        static void Main(string[] args)
        {
            string[] words = new string[ArrayLength];
            Console.Write("Enter a word: ");
            string wordEntered = Console.ReadLine();
            int numberOfWords = 0;

            while ((wordEntered != string.Empty) && (numberOfWords < ArrayLength))
            {
                words[numberOfWords] = wordEntered;
                numberOfWords++;
                Console.Write("Enter a word: ");
                wordEntered = Console.ReadLine();
            }
            for (int i = 0; i <numberOfWords; i++)
            {
                if (words[i].Length%2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine($"{words[i]}");
            }
            Console.ResetColor();
            Console.WriteLine("End of program");
        }
    }
}