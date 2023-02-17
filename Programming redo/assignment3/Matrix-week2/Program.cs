namespace Matrix_week2
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
            int[,]Matrix = new int[numberOfRows, numberOfColumns];
            InitMatrixLinear(Matrix);
            DisplayMatrixWithCross(Matrix);
        }
        void InitMatrix2D(int[,] Matrix)
        {
            int number = 1;
            for (int row = 0; row< Matrix.GetLength(0); row++)
            {
                for (int column = 0; column<Matrix.GetLength(1); column++)
                {
                    Matrix[row, column] = number;
                    number++;
                }
            }
        }
        void DisplayMatrix(int[,] Matrix)
        {
            for(int row = 0; row<Matrix.GetLength(0); row++)
            {
                for (int column = 0; column<Matrix.GetLength(1); column++)
                {
                    Console.Write($"{Matrix[row,column],3}");
                }
                  Console.WriteLine();
            }
        }
        void InitMatrixLinear(int[,] Matrix)
        {
            for(int i = 1; i<Matrix.Length; i++)
            {
                int rowDiagonalElement = (i-1)/Matrix.GetLength(0);
                int columnDiagonalElement = (i - 1)%Matrix.GetLength(1);
                Matrix[rowDiagonalElement, columnDiagonalElement] = i;
            }
        }
        void DisplayMatrixWithCross(int[,] Matrix)
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int column = 0; column < Matrix.GetLength(1); column++)
                {
                    if (row == column)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                    }
                    else if(Matrix.GetLength(1) - column -1 == row)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write($"{Matrix[row, column],3}");
                    Console.ResetColor();
                }

                Console.WriteLine();
            }
        }
    }
}