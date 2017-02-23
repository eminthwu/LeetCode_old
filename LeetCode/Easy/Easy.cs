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
            long tail = 0;
            long result = 0;
            int output = 0;

            //int y = int.MaxValue + 1;

            try
            {
                while (x != 0)
                {
                    tail = x % 10;
                    result = result * 10 + tail;
                    x = x / 10;
                    output = Convert.ToInt32(result);
                }
            }
            catch (OverflowException e)
            {
                return 0;
            }

            return output;
        }

        public bool IsPalindrome(int x)
        {
            Func<string, int, int, bool> checkPalindrome = (string s, int begin, int end) =>
            {
                while (begin >= 0 && end < s.Length)
                {
                    if (s[begin] == s[end])
                    {
                        begin--;
                        end++;
                    }
                    else
                    {
                        break;
                    }
                }

                return begin == -1 && end == s.Length;
            };


            if (x == 0)
                return true;
            else if (x == int.MaxValue || x < 0)
                return false;

            int digits = (int)Math.Floor(Math.Log10(x) + 1);
            var mid = digits / 2;
            var minusOne = digits % 2 == 0 ? 1 : 0;            

            return checkPalindrome(x.ToString(), mid - minusOne, mid);
        }

        public bool ValidParentheses(string s)
        {
            throw new NotImplementedException();
        }
    }
}