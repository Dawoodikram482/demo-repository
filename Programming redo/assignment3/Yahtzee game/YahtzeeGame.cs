using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_game
{
    public class YahtzeeGame
    {
        const int lengthOfArray = 5;
        Dice[] dices = new Dice[lengthOfArray];

        public void Init()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                Dice dice = new Dice();
                dices[i] = dice;
            }
        }
        public void Throw()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].Throw();
            }
        }
        public void DisplayValues()
        {
            for (int i = 0; i < dices.Length; i++)
            {
                dices[i].DisplayValue();
                
            }
            Console.WriteLine();
        }
        public bool Yahtzee()
        {
            bool yahtzeeThrown = true;
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[0].value!= dices[i].value)
                {
                    yahtzeeThrown = false;
                    break;
                }

            }
            return yahtzeeThrown;
        }
    }
}
