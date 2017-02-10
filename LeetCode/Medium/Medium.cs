using System;
using LeetCode.Definition;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class Medium
    {
        #region AddTwoNumber        

        public ListNode AddTwoNumber(ListNode first, ListNode second)
        {
            var l1 = new List<int>();
            var l2 = new List<int>();
            var index = first;
            var carry = false;
            var result = new List<string>();

            while (first != null || second != null || carry)
            {
                if (first != null && second != null)
                {
                    var val = first.val + second.val + (carry ? 1 : 0);
                    var value = (val % 10).ToString();
                    result.Add(value);
                    carry = val >= 10;
                    first = first.next;
                    second = second.next;
                }
                else if (first == null && second != null)
                {
                    var val = second.val + (carry ? 1 : 0);
                    var value = (val % 10).ToString();
                    result.Add(value);
                    carry = val >= 10;
                    second = second.next;
                }
                else if (second == null && first != null)
                {
                    var val = first.val + (carry ? 1 : 0);
                    var value = (val % 10).ToString();
                    result.Add(value);
                    carry = val >= 10;
                    first = first.next;
                }
                else if (carry)
                {
                    result.Add("1");
                    carry = false;
                }
            }

            //result.Reverse();

            ListNode output = null;
            var i = 0;

            foreach (var r in result)
            {
                var val = Convert.ToInt32(r);

                if (i == 0)
                    output = new ListNode(val);
                else
                    TraceLastNode(output).next = new ListNode(val);

                i++;
            }

            return output;
        }

        private ListNode TraceLastNode(ListNode node)
        {
            if (node.next == null)
                return node;
            else
                return TraceLastNode(node.next);
        }

        public string LongestPalindrome(string input)
        {
            var result = "";

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    var temp = input.Skip(i).Take(j + 1 - i);
                    var x = new string(temp.ToArray());
                    if (i == 16)
                    {

                    }
                    if (x == new string(temp.Reverse().ToArray()) && x.Length >= result.Length)
                    {
                        result = x;
                    }
                }
            }

            return result;
        }

        #endregion


    }
}