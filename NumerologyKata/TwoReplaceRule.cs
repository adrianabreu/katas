using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerologyKata
{
    public class TwoReplaceRule : ReplaceRule
    {
        public int[] Replace(int[] input)
        {
            var list = new List<int>();

            for (int index = 0; index < input.Length; index++)
            {
                var number = input[index];

                if (NotMatch(number) || NoNumberToTheLeft(index))
                {
                    list.Add(number);
                    continue;
                }

                var numberToTheLeft = input[index - 1];
                AddAsManyOnesAsNumberToTheLeft(list, numberToTheLeft);
            }

            return list.ToArray();
        }

        private static void AddAsManyOnesAsNumberToTheLeft(List<int> list, int numberToTheLeft)
        {
            for (int y = 0; y < numberToTheLeft; y++)
            {
                list.Add(1);
            }
        }

        private bool NotMatch(int number)
        {
            return number != 2;
        }

        private static bool NoNumberToTheLeft(int index)
        {
            return index == 0;
        }
    }
}
