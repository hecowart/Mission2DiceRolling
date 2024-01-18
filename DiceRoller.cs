using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller
    {
        Random random = new Random();
        public int[] RollDeDice(int iTotalRolls)  //public int[] to let it know that I will be returning an array at the end
        {
            //create the array
            int[] aiRollTotals = new int[13];

            //for loop that rolls the dice as many times as the user wanted
            for (int iCount = 0; iCount < iTotalRolls; iCount++)
            {
                //declaring our dice and randomizing/rolling to get a value
                int iDie1 = random.Next(1, 7);
                int iDie2 = random.Next(1, 7);
                //sum up total value
                int iTotalSides = iDie1 + iDie2;

                aiRollTotals[iTotalSides]++;   //add essentially a tally mark into the apartment associated with the value in the array
            }

            return aiRollTotals;
        }
    }
}
