namespace week2_assignment1
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

            InitMatrix2D(matrix);
            DisplayMatrixWithCross(matrix);
        }
        void InitMatrix2D(int[,] matrix)
        {
            int number = 1;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[rows, column] = number;
                    number++;
                }
            }
        }
        void DisplayMatrix2D(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.WriteLine($"{matrix[rows, column],3}");
                }
            }
        }
        void InitMatrixLinear(int[,] matrix)
        {
            for (int i = 0; i <= matrix.Length; i++)
            {
                int rowDiagonalElement = (i - 1) / matrix.GetLength(1);
                int columnDiagonalElement = (i - 1) % matrix.GetLength(1);
                matrix[rowDiagonalElement, columnDiagonalElement] = i;
            }
        }
        void DisplayMatrixWithCross(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (rows == column)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                    } 
                    
                    if (matrix.GetLength(1) - column - 1 == rows)
                    {
                        Console.ForegroundColor= ConsoleColor.Yellow;
                    }
                    Console.Write($"{matrix[rows,column] , 3}");
                    
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }
    }
}