using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yahtzeegame
{
    class GameYahtzee
    {
        const int lengthOfArray = 5;
        dice[] dices = new dice[lengthOfArray];

        public void Init()
        {
            for (int i = 0; i < lengthOfArray; i++)
            {
                dice dice = new dice();
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
        public void DisplayValue()
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
                if (dices[0].value != dices[i].value)
                {
                    yahtzeeThrown = false;
                }
            }
            return yahtzeeThrown;
        }
    }
}
