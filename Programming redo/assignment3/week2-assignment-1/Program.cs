namespace week2_assignment_1
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
            int[,] Matrix = new int[numberOfRows, numberOfColumns];
            InitMatrix(Matrix, 1, 100);
            DisplayMatrix(Matrix);

            Console.WriteLine("Enter a number to search: ");
            int searchNumber = int.Parse(Console.ReadLine());

            Position position = SearchNmber(Matrix, searchNumber);
            Console.WriteLine($"Number {searchNumber} is found at [{position.row},{position.col}]");

            Position PositionBAckwards = SearchNumberBackwards(Matrix, searchNumber);
            Console.WriteLine($"Number {searchNumber} is found at [{PositionBAckwards.row}, {PositionBAckwards.col}]");
        }
        void InitMatrix(int[,] Matrix, int min, int max)
        {
            Random random = new Random();
            
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    Matrix[row, column] = random.Next(min, max);
                    
                }
            }
        }
        void DisplayMatrix(int[,] Matrix)
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    Console.Write($"{Matrix[row, column],3}");
                }
                Console.WriteLine();
            }
        }
        Position SearchNmber(int[,] matrix, int number)
        {
            Position position = new Position();
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
                return null;
        }
        Position SearchNumberBackwards(int[,] matrix, int number)
        {
            Position position = new Position();
            for (int row = matrix.GetLength(0) -1; row >=0 ; row--)
            {
                for (int column = matrix.GetLength(1) - 1; column >=0; column--)
                {
                    if (matrix[row, column] == number)
                    {
                    position.row = row;
                    position.col = column;
                    return position;
                    }
                }
            }
            return null;
        }
    }
}