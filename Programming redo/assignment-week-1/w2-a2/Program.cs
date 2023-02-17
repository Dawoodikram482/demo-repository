namespace w2_a2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("invalid number of arguments!");
                Console.WriteLine("usage: assignment[1-3] <nr of rows> <nr of columns>");
                return;
            }
            int numberOfRows = int.Parse(args[0]);
            int numberOfColumns = int.Parse(args[1]);
            Program myProgram = new Program();
            myProgram.Start(numberOfRows, numberOfColumns);
        }
        void Start(int numberOfRows, int numberOfColumns)
        {
            int[,] matrix = new int[numberOfRows, numberOfColumns];
            InitMatrixRandom(matrix, 1, 100);
            DisplayMatrix(matrix);

            Console.WriteLine("Enter a search number:");
            int searchNumber = int.Parse(Console.ReadLine());

            position pos = SearchNumber(matrix, searchNumber);
            Console.WriteLine($" first number found at [{pos.row},{pos.col}] ");

            position backwardpos = SearchNumberBackwards(matrix, searchNumber);
            Console.WriteLine($" last number found at [{backwardpos.row}, {backwardpos.col}]");
        }
        void InitMatrixRandom(int[,] matrix, int min, int max)
        {
            Random rnd = new Random();
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    matrix[rows, columns] = rnd.Next(min,max);
                }
            }
        }
        void DisplayMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column],3}");
                }
                Console.WriteLine();
            }
        }
        position SearchNumber(int[,] matrix, int number)
        {
            position position = new position();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (matrix[row, column] == number)
                    {
                        position.row = row;
                        position.col = column;

                        return position;
                    }
                }
            }
            return position;
        }
        position SearchNumberBackwards(int[,] matrix, int numberBackwards)
        {
            position pos = new position();
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int column = matrix.GetLength(1) - 1; column >=0; column--)
                {
                    if (matrix[row, column] == numberBackwards)
                    {
                        pos.row = row;
                        pos.col = column;

                        return pos;
                    }
                }
            }
            return pos;
        }
    }
}