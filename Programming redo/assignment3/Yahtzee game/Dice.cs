using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_game
{
    public class Dice
    {
        public int value;
        static Random random = new Random();

        public void Throw()
        {
            value = random.Next(1, 7);
        }
        public void DisplayValue()
        {
            Console.Write($"{value} ");
        }
    }
}
