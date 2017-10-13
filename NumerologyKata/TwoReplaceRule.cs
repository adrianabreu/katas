using System;
using System.Collections.Generic;
using System.Text;

namespace NumerologyKata
{
    public class TwoReplaceRule : ReplaceRule
    {
        public bool Matches(int number)
        {
            return number == 2;
        }

        public int[] Replace(int[] input, int index)
        {
            var list = new List<int>();
            var number = input[index];
            var numberToTheLeft = input[index - 1];

            for (int y = 0; y < numberToTheLeft; y++)
            {
                list.Add(1);
            }
            return list.ToArray();
        }
    }
}
