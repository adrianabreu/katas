using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumerologyKata
{
    public class TwoReplaceRule : ReplaceRule
    {
        private bool Matches(int number)
        {
            return number == 2;
        }
       
        public int[] Replace(int[] input)
        {
            var list = new List<int>();

            for (int index = 0; index < input.Length; index++)
            {
                var number = input[index];

                if (!Matches(number))
                {
                    list.Add(number);
                    continue;
                }
                
                var numberToTheLeft = input[index - 1];

                for (int y = 0; y < numberToTheLeft; y++)
                {
                    list.Add(1);
                }
            }

            return list.ToArray();
        }
    }
}
