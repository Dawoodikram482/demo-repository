namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string wordEntered = Console.ReadLine();

            string wordToCheck = "";
            //int lengthOfWord = wordEntered.Length - 1;

            //while (lengthOfWord >= 0)
            //{
            //    wordToCheck += wordEntered[lengthOfWord];
            //    lengthOfWord--;
            //}

            foreach (char c in wordEntered)
            {
                wordToCheck = c + wordToCheck;
            }

            if (wordEntered == wordToCheck)
            {
                Console.WriteLine($"{wordEntered} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{wordEntered} is not a palindrome");
            }
        }
    }
}