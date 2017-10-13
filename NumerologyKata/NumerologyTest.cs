using System;
using Xunit;
using FluentAssertions;

namespace NumerologyKata
{
    public class NumerologyTest
    {
        [Fact]
        public void WhenInputContains9_ReplaceThemByTwo10()
        {
            var numerology = new Numerology();
            var input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var expected_output = new int[] { 1, 1, 3, 4, 5, 6, 7, 8, 10, 10, 10 };
            var result = numerology.Parse(input);
            expected_output.ShouldBeEquivalentTo(result);
        }

        [Fact]
        public void ReplaceAll2sByAnEqualNumberOf1sAsTheNumberToTheLeft()
        {
            var numerology = new Numerology();
            var input = new int[] { 3, 2, 3, 4, 5 };
            var expected_output = new int[] { 3, 1, 1, 1, 3, 4, 5};
            var result = numerology.Parse(input);
            expected_output.ShouldBeEquivalentTo(result);
        }
    }
}
