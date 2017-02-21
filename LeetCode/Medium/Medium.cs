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

        #endregion


        public string LongestPalindrome(string s)
        {
            /*回文可以想成，找出中間的那個字元，接著左右兩邊對稱*/
            int begin = 0, end = 0;

            string result = "";

            for (int i = 0; i < s.Length;)
            {
                var odd = t(s, begin, end);
                var even = t(s, begin, end + 1);

                var max = odd.Length > even.Length ? odd : even;
                result = result.Length >= max.Length ? result : max;                

                begin = end = ++i;
            }

            return result;

        }

        public string t(string s, int begin, int end)
        {
            var result = "";

            while (begin >= 0 && end < s.Length)
            {
                if (s[begin] == s[end])
                {
                    var temp = s.Substring(begin, end - begin + 1);
                    //result = end - begin + 1;
                    result = temp.Length > result.Length ? temp : result;
                    begin--;
                    end++;
                }
                else
                {
                    break;
                }
            }

            return result;
        }

        public int ThreeSumClosest(int[] nums, int target)
        {
            throw new NotImplementedException();
        }
    }
}


