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

        public int RomanToInt(string s)
        {
            string[] M = { "", "M", "MM", "MMM" };
            string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            Func<string[], string, int> func = (string[] array, string str) =>
            {
                var result = 0;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    var rome = array[i];
                    var compare = str.Substring(0, rome.Length);

                }
                str = "";

                return result;
            };

            return Func(M, ref s) * 1000 + Func(C, ref s) * 100 + Func(X, ref s) * 10 + Func(I, ref s);
            return func(M, s) * 1000 + func(C, s) * 100 + func(X, s) * 10 + func(I, s);
        }

        private int Func(string[] array, ref string str)
        {
            var result = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                var rome = array[i];

                if(str.Length < rome.Length)
                {
                    continue;
                }

                var compare = str.Substring(0, rome.Length);

                if (rome == compare)
                {
                    result = i;
                    str = str.Remove(0, rome.Length);
                    break;
                }

            }


            return result;
        }
    }
}