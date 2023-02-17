namespace Practice_exam_term_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }
        void Start()
        {
            Console.WriteLine("Enter ISBN number: ");
            string isbn = Console.ReadLine();

            try
            {
                switch (ValidateISBN(isbn))
                {
                    case ISBNValidation.InvalidISBN:
                        Console.WriteLine("Invalid ISBN number");
                        break;
                    case ISBNValidation.ValidISBN13:
                        Console.WriteLine("Valid ISBN-13 number");
                        break;
                }
            } catch(Exception exp)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(exp.Message);
                Console.ResetColor();           
            }
        }
        ISBNValidation ValidateISBN(string isbn)
        {
            if (isbn.Length >= 13)
            {
                if (IsValidISBN13(isbn))
                {
                    return ISBNValidation.ValidISBN13;
                }
            }
            return ISBNValidation.InvalidISBN;
        }
        bool IsValidISBN13(string isbn)
        {
            isbn = isbn.Replace("-", "");

            if (isbn.Length != 13)
            {
                return false;
            }
            int sum = 0;
            for (int i = 0; i < isbn.Length; i++)
            {
                if ((isbn[i]<'0') || (isbn[i]>'9'))
                {
                    throw new Exception("Invalid character!");
                }
                int digit = isbn[i] - '0';
                if (i % 2 == 1)
                {
                    sum += digit * 3;
                }
                else
                {
                    sum += digit;
                }
            }
            if (sum % 10 == 0)
            {
                return true;
            }

            return false;


        }
    }
}