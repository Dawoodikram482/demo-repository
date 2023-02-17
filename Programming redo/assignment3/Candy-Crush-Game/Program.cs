using System;
using System.Data.SqlTypes;

namespace Candy_Crush_Game
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
            RegularCandies[,] PlayingField = new RegularCandies[numberOfRows, numberOfColumns];
            InitCandies(PlayingField);
            DisplayCandies(PlayingField);

            if (ScoreRowPresent(PlayingField))
            {
                Console.WriteLine("row score");
            }
            else
            {
                Console.WriteLine("no row score");
            }
            if (ScoreColumnPresent(PlayingField)) 
            {
                Console.WriteLine("column score ");
            }
            else
            {
                Console.WriteLine("no column score");
            }
        }
        void InitCandies(RegularCandies[,] PlayingField)
        {
            Random random = new Random();
            for (int row = 0; row < PlayingField.GetLength(0); row++)
            {
                for (int columm = 0; columm < PlayingField.GetLength(1); columm++)
                {
                    PlayingField[row, columm] = (RegularCandies)random.Next(0, Enum.GetNames(typeof(RegularCandies)).Length);
                }
            }
        }
        void DisplayCandies(RegularCandies[,] PlayingField)
        {
            for (int row = 0; row < PlayingField.GetLength(0); row++)
            {
                for (int columm = 0; columm < PlayingField.GetLength(1); columm++)
                {
                    switch (PlayingField[row, columm])
                    {
                        case RegularCandies.JellyBean:
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            break;
                        case RegularCandies.LemonDrop:
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            break;
                        case RegularCandies.Lozenge:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            }
                            break;
                        case RegularCandies.GumSquare:
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            break;
                        case RegularCandies.LollipopHead:
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            break;
                        case RegularCandies.JujubeCluster:
                            {
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                            }
                            break;
                    }
                    Console.Write(" #");
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }
        bool ScoreRowPresent(RegularCandies[,] PlayingField)
        {
            
            for (int row = 0; row < PlayingField.GetLength(0); row++)
            {
                int count = 1;
                for (int columm = 1; columm < PlayingField.GetLength(1); columm++)
                {
                    if (PlayingField[row,columm] == PlayingField[row, columm -1])
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
        bool ScoreColumnPresent(RegularCandies[,] PlayingField)
        {
            for (int column = 0; column<PlayingField.GetLength(1); column++)
            {
                int count = 1;
                for (int row = 1; row < PlayingField.GetLength(0); row++)
                {
                    if (PlayingField[row, column] == PlayingField[row-1, column])
                    {
                        count++;
                        if(count == 3)
                        {
                            return true;
                        }
                        else
                        {
                            count = 1;
                        }
                    }
                }
            }
            return false;
        }
    }
}