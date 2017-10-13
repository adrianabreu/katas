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
            foreach (var item in input)
            {
                if (item == 9)
                {
                    list.Add(10);
                    list.Add(10);
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