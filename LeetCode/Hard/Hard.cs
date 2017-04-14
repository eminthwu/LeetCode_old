using LeetCode.Definition;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    public class Hard
    {
        public int FindMinStep(string board, string hand)
        {
            //var boardGroups = board.Select(s => s.ToString()).GroupBy(s => s).Select(s => new { Color = s.Key, Count = s.Count() });
            //foreach (var b in boardGroups)
            //{
            //    if(b.Count <= hand.)
            //}

            return 0;
        }

        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var origin = head;
            var index = 0;
            var first = head;
            ListNode result = null;
            ListNode output = result;
            ListNode prev = null;

            List<Func<ListNode>> funcs = new List<Func<ListNode>>();

            while (head != null)
            {
                index++;
                prev = head;
                head = head.next;

                if (index % k == 0)
                {
                    prev.next = null;         
                    var func = Reverse(first);
                    first = head;
                    funcs.Add(func);
                }               

            }

            if (funcs.Count == 0)
            {
                return first;
            }

            Func<ListNode, ListNode> findLast = (node) =>
            {
                while (node.next != null)
                {
                    node = node.next;
                }

                return node;
            };

            //result = funcs[0]();

            for (int i = 0; i < funcs.Count; i++)
            {
                var func = funcs[i];
                if (i == 0)
                {
                    result = func();
                    output = result;
                }
                else
                {
                    result = findLast(result);
                    result.next = func();
                }


                if (i == funcs.Count - 1)
                {
                    result = findLast(result);
                    result.next = first;
                }
            }

            return output;
        }

        private Func<ListNode> Reverse(ListNode first)
        {
            Func<ListNode, Func<ListNode>> func = (n) =>
             {
                 Func<ListNode> f = () =>
                 {
                     var node = Switch(n);
                     return node;
                 };

                 return f;
             };

            return func(first);

        }

        public ListNode Switch(ListNode a)
        {
            if (a.next != null)
            {
                var b = Switch(a.next);
                a.next = null;
                var c = b;
                while (c != null && c.next != null)
                {
                    c = c.next;
                }
                c.next = a;
                return b;
            }
            else
                return a;
        }
    }
}