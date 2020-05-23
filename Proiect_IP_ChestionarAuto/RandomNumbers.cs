using System;
using System.Collections.Generic;

namespace Proiect_IP_ChestionarAuto
{
    internal static class RandomNumbers
    {
        public static IEnumerable<int> Generate(int max, int total)
        {
            var rnd = new Random();
            var numbers = new List<int>();

            for (var i = 0; i < total; i++)
            {
                var temp = rnd.Next(1, max + 1);

                while (numbers.Contains(temp))
                {
                    temp = rnd.Next(1, max + 1);
                }

                numbers.Add(temp);
            }

            return numbers;
        }
    }
}
