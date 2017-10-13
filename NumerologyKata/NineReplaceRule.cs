using System.Collections.Generic;

namespace NumerologyKata
{
    public class NineReplaceRule : ReplaceRule
    {
        private bool Matches(int number)
        {
            return number == 9;
        }

        public int[] Replace(int[] input)
        {
            List<int> numbers = new List<int>();
            foreach (var number in input)
            {
                if (Matches(number))
                    numbers.AddRange(new int[] { 10, 10 });
                else
                    numbers.Add(number);
            }
            return numbers.ToArray();
        }
       
    }
}