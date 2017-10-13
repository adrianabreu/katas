using System;
using System.Collections.Generic;
using System.Linq;

namespace NumerologyKata
{
    internal class Numerology
    {
        public Numerology()
        {
        }

        public int[] Parse(int[] input)
        {
            var list = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                var item = input[i];
                if (item == 9)
                {
                    list.Add(10);
                    list.Add(10);
                }
                else if(item == 2)
                {
                    var numberToTheLeft = input[i - 1];
                    for (int y = 0; y < numberToTheLeft; y++)
                    {
                        list.Add(1);
                    }
                }
                else
                {
                    list.Add(item);
                }
            }
            return list.ToArray();
        }
    }
}