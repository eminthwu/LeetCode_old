using System;
using LeetCode.Definition;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    public class Medium
    {
        public ListNode AddTwoNumber(ListNode first, ListNode second)
        {
            var l1 = new List<int>();
            var l2 = new List<int>();
            var index = first;

            while (first != null)
            {
                l1.Add(first.val);               
                first = first.next;               
            }

            while (second != null)
            {                
                l2.Add(second.val);               
                second = second.next;
            }

            l1.Reverse();
            l2.Reverse();

            var a = Convert.ToInt64(string.Join<int>("", l1));
            var b = Convert.ToInt64(string.Join<int>("", l2));

            var c = (a + b).ToString().ToCharArray().ToList();
            c.Reverse();

            ListNode output = null;

            for (int i = 0; i < c.Count; i++)
            {
                // var val = (l1[i] + l2[i]) % 10;
                var val = Convert.ToInt32(c[i].ToString());

                if (i == 0)
                    output = new ListNode(val);
                else
                    TraceLastNode(output).next = new ListNode(val);
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
    }
}