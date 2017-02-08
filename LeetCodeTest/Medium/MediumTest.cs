using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium;
using LeetCode.Definition;
using ExpectedObjects;

namespace LeetCodeTest
{
    [TestClass]
    public class MediumTest
    {
        [TestMethod]
        public void AddTwoNumbers()
        {
            /*
                You are given two non-empty linked lists representing two non-negative integers. 
                The digits are stored in reverse order and each of their nodes contain a single digit. 
                Add the two numbers and return it as a linked list.
                You may assume the two numbers do not contain any leading zero, except the number 0 itself.
                Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
                Output: 7 -> 0 -> 8
             */

            //Arrange 
            Medium target = new Medium();
            var first = new ListNode(2)
            {
                Next = new ListNode(4)
                {
                    Next = new ListNode(3)
                }
            };

            var second = new ListNode(5)
            {
                Next = new ListNode(6)
                {
                    Next = new ListNode(4)
                }
            };

            var expected = new ListNode(7)
            {
                Next = new ListNode(0)
                {
                    Next = new ListNode(8)
                }
            };

            //Act
            ListNode actual = target.AddTwoNumber(first, second);

            //Assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
