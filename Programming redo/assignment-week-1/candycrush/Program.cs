using System;

namespace candycrush
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
            RegularCandies[,] playingField = new RegularCandies[numberOfRows, numberOfColumns];

            InitCandies(playingField);
            DisplayCandies(playingField);

            if (RowScorePresent(playingField))
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }

            if (ColumnScorePresent(playingField))
            {
                Console.WriteLine("column score");
            }
            else
            {
                Console.WriteLine("no column score");
            }
        }
        void InitCandies(RegularCandies[,] gameField)
        {
            Random random = new Random();
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int column = 0; column < gameField.GetLength(1); column++)
                {
                    gameField[row, column] = (RegularCandies)random.Next(0,Enum.GetNames(typeof(RegularCandies)).Length);
                }
            }
        }
        void DisplayCandies(RegularCandies[,] gameField)
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                for (int column = 0; column < gameField.GetLength(1); column++)
                {
                    switch(gameField[row, column])
                    {
                        case RegularCandies.JellyBean:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case RegularCandies.LemonDrop:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        case RegularCandies.GumSquare:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case RegularCandies.Lozenge:
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            break;
                        case RegularCandies.JujubeCluster:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case RegularCandies.LollipopHead:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                    }
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
        //bool RowScorePresent(RegularCandies[,] gameField)
        //{
        //    for (int row = 0; row < gameField.GetLength(0); row++)
        //    {
        //        int count = 1;
        //        for (int column = 0; column < gameField.GetLength(1); column++)
        //        {
        //            if (gameField[row, column] == gameField[row,column-1])
        //            {
        //                count++;
        //                if (count == 3)
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    count = 1;
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}
        bool RowScorePresent(RegularCandies[,] gameField)
        {
            for (int row = 0; row < gameField.GetLength(0); row++)
            {
                int count = 1;
                for (int column = 1; column < gameField.GetLength(1); column++)
                {
                    if (gameField[row, column] == gameField[row, column - 1])
                    {
                        count++;
                        if (count == 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return false;
        }
        //bool ColumnScorePresent(RegularCandies[,] gameField)
        //{
        //    for (int column = 0; column < gameField.GetLength(1); column++)
        //    {
        //        int count = 1;
        //        for (int row = 0; row < gameField.GetLength(0); row++)
        //        {
        //            if (gameField[row, column] == gameField[row-1, column])
        //            {
        //                count++;
        //                if (count == 3)
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    count = 1;
        //                }
        //            }
        //        }
        //    }
        //    return false;
        //}
        bool ColumnScorePresent(RegularCandies[,] gameField)
        {
            for (int column = 0; column < gameField.GetLength(1); column++)
            {
                int count = 1;
                for (int row = 1; row < gameField.GetLength(0); row++)
                {
                    if (gameField[row, column] == gameField[row - 1, column])
                    {
                        count++;
                        if (count == 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            return false;
        }
    }
}