using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerologyKata
{

    internal class Numerology
    {
        IEnumerable<ReplaceRule> _replacers;

        public Numerology()
        {
            _replacers = new ReplaceRule[]
            {
                new TwoReplaceRule(),
                new NineReplaceRule()                
            };
        }

        public int[] Parse(int[] input)
        {
            foreach (var replacer in _replacers)
            {
                input = replacer.Replace(input);
            }
            return input;
        }
    }
}