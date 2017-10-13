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
                new NineReplaceRule(),
                new DefaultReplaceRule()
            };
        }

        public int[] Parse(int[] input)
        {
            var list = input
                        .SelectMany((number, index) =>
                        {
                            var replacer = _replacers.First(r => r.Matches(number));
                            return replacer.Replace(input, index);
                        });
            return list.ToArray();
        }
    }
}