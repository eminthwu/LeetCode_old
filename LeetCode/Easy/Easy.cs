using System;
using System.Linq;

namespace LeetCode.Easy
{
    public class Easy
    {
        public int[] TwoSum(int[] given, int specificTarget)
        {
            int[] output = default(int[]);

            for (int i = 0; i < given.Length - 1; i++)
            {
                for (int j = i + 1; j < given.Length; j++)
                {
                    if (given[i] + given[j] == specificTarget)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return output;
        }

        public int ReverseInt(int x)
        {
            try
            {
                var str = Math.Abs(x).ToString();
                var x1 = str.Reverse();
                var result = Convert.ToInt32(new string(x1.ToArray()));

                return x > 0 ? result : result * -1;
            }
            catch(OverflowException e)
            {
                return 0;
            }
        }
    }
}