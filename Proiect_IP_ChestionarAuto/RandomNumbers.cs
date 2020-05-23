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
                var temp = rnd.Next(0, max );

                while (numbers.Contains(temp))
                {
                    temp = rnd.Next(0, max);
                }

                numbers.Add(temp);
            }

            return numbers;
        }
    }
}
