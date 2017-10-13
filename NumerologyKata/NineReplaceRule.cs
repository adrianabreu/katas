using System.Collections.Generic;

namespace NumerologyKata
{
    public class NineReplaceRule : ReplaceRule
    {
        public bool Matches(int number)
        {
            return number == 9;
        }

        public int[] Replace(int[] input, int index)
        {
            return new int[] { 10, 10 };
        }
    }
}