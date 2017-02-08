using System;
using LeetCode.Definition;
using System.Collections.Generic;

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
                l2.Add(second.val);
                first = first.next;
                second = second.next;
            }

            ListNode output = null;

            for (int i = 0; i < l1.Count; i++)
            {
                var val = (l1[i] + l2[i]) % 10;
                //var valNext = (l1[i + 1] + l2[i + 1]) % 10;

                if (i == 0)
                    output = new ListNode(val);
                else
                    TraceLastNode(output).next = new ListNode(val);
                //output.next = new ListNode(valNext);
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