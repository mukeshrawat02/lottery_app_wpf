using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryApp.Common.Utils
{
    public static class LotteryHelper
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// This method will be responsible for Generating non-repeating set of lottery numbers based on inputs
        /// </summary>
        /// <param name="count">Sequence, example if count is 6 then the function will return non-repeating set of six lottery numbers</param>
        /// <param name="min">Minimum number of the sequence</param>
        /// <param name="max">Maximum number of the sequence</param>
        /// <returns></returns>
        public static List<int> GenerateLotteryNumbers(int count, int min, int max)
        {
            // basic checks on the parameters
            if (max <= min || count < 0 || (count > max - min && max - min > 0))
            {
                throw new ArgumentOutOfRangeException();
            }

            // taking advantage of the HashSet for elimination of duplicates.
            var numbers = new HashSet<int>();
            while (numbers.Count < count)
            {
                numbers.Add(Random.Next(min, max));
            }

            // load them in to a list.
            var result = new List<int>();
            result.AddRange(numbers);

            // shuffle the results
            result.Shuffle();

            return result;
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
