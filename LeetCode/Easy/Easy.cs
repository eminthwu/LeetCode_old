using System;
using System.Collections.Generic;
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
            var stack = new Stack<char>();
            Dictionary<char, char> config = new Dictionary<char, char>()
            {
                {'(',')' },{')','(' },
                {'[',']' },{']','[' },
                {'{','}' },{'}','{' }
            };

            var left = new char[] { '{', '[', '(' };
            var right = new char[] { '}', ']', ')' };


            foreach (var c in s)
            {
                var index = stack.Count - 1;

                if (left.Contains(c))
                {
                    stack.Push(c);
                }
                else if (index >= 0 && right.Contains(c) && config[c] == stack.Peek())
                {
                    stack.Pop();
                }
                else
                    return false;
            }

            return stack.Count == 0;
        }

        public ListNode MergeTwoSortedLists(ListNode l1, ListNode l2)
        {            
            ListNode result = null;
            ListNode temp = null;

            if (l1 == null && l2 == null)
                return null;
            else if (l1 == null)
                return l2;
            else if (l2 == null)
                return l1;
            else if(l1.val <= l2.val)
            {
                result = new ListNode(l1.val);
                temp = result;
                l1 = l1.next;
            }
            else
            {
                result = new ListNode(l2.val);
                temp = result;
                l2 = l2.next;
            }

            do
            {
                if(l1==null)
                {
                    temp.next = l2;
                    break;
                }
                else if(l2 == null)
                {
                    temp.next = l1;
                    break;
                }
                else
                {
                    if(l1.val <= l2.val)
                    {
                        temp.next = new ListNode(l1.val);
                        temp = temp.next;
                        l1 = l1.next;
                    }
                    else
                    {
                        temp.next = new ListNode(l2.val);
                        temp = temp.next;
                        l2 = l2.next;
                    }
                }
            }
            while (l1 != null || l2 != null);

            return result;
        }        
    }

    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }
    }
}