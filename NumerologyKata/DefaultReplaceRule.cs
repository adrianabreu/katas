using System;
using System.Collections.Generic;
using System.Text;

namespace NumerologyKata
{
    public class DefaultReplaceRule : ReplaceRule
    {
        public bool Matches(int number)
        {
            return true;
        }

        public int[] Replace(int[] input, int index)
        {
            return new int[] { input[index] };
        }
    }
}
