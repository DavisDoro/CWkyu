using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// int[6] dice
//Three 1's => 1000 points
// Three 6's =>  600 points
// Three 5's =>  500 points
// Three 4's =>  400 points
// Three 3's =>  300 points
// Three 2's =>  200 points
// One 1   =>  100 points
// One   5   =>   50 point
//Throw Score
// ---------   ------------------
//    5 1 3 4 1   250:  50(for the 5) +2 * 100(for the 1s)
//    1 1 1 3 1   1100: 1000(for three 1s) +100(for the other 1)
//    2 4 4 5 4   450:  400(for three 4s) +50(for the 5)

namespace CWkyu._5kyu
{
    public class GreedIsGood
    {

        public int Score(int[] dice)
        {
            int yourScore = 0;
            int[] restOfDice = dice;

            var dictionary = new Dictionary<int, int>();
            foreach (int diceItem in dice)
            {
                if (!dictionary.ContainsKey(diceItem))
                {
                    dictionary[diceItem] = 0;
                }
                dictionary[diceItem]++;
            }
            foreach (var pair in dictionary)
            {
                if (pair.Value >= 3 && pair.Key == 1)
                {
                    yourScore += pair.Key * 1000;
                    restOfDice = ReplaceUsed(pair.Key, dice);
                }
                else if (pair.Value >= 3)
                {
                    yourScore += pair.Key * 100;
                    restOfDice = ReplaceUsed(pair.Key, dice);
                }
            }
            foreach (var item in restOfDice)
            {
                if (item == 1)
                {
                    yourScore += 100;
                }
                if (item == 5)
                {
                    yourScore += 50;
                }
            }

            return yourScore;
        }
        public int[] ReplaceUsed(int value, int[] dice)
        {
            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                if (count == 3)
                {
                    break;
                }
                else if (dice[i] == value)
                {
                    dice[i] = 0;
                    count++;
                }
            }
            return dice;
        }
    }
}

