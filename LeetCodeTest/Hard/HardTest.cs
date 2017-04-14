using LeetCode.Hard;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium;
using LeetCode.Definition;
using ExpectedObjects;

namespace LeetCodeTest
{
    [TestClass]
    public class HardTest
    {
        [TestMethod()]
        public void ReverseKGroupTest()
        {
            int group = 3;
            var node = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(7)
                    {
                        next = new ListNode(8)
                        {
                            next = new ListNode(9)
                            {
                            }
                        }
                    }
                }
            };

            var expected = new ListNode(7)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(5)
                    {
                        next = new ListNode(8)
                        {
                            next = new ListNode(9)
                            {
                            }
                        }
                    }
                }
            };

            var target = new Hard();
            var actual = target.ReverseKGroup(node, group);

            expected.ToExpectedObject().ShouldEqual(actual);

        }

        [TestMethod()]
        public void Switch()
        {
            var node =
                new ListNode(5)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(7)
                        {
                            //Next = new ListNode(8)
                            //{
                            //    Next = new ListNode(9)
                            //    {
                            //    }
                            //}
                        }
                    }
                };

            var expected =
                new ListNode(7)
                {
                    next = new ListNode(6)
                    {
                        next = new ListNode(5)
                        {
                            //Next = new ListNode(6)
                            //{
                            //    Next = new ListNode(5)
                            //    {
                            //    }
                            //}
                        }
                    }
                };

            var target = new Hard();
            var actual = target.Switch(node);

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            /*
             * Think about Zuma Game. You have a row of balls on the table, colored red(R), yellow(Y), blue(B), green(G), and white(W). 
             * You also have several balls in your hand.
                Each time, you may choose a ball in your hand, and insert it into the row (including the leftmost place and rightmost place). 
                Then, if there is a group of 3 or more balls in the same color touching, remove these balls. 
                Keep doing this until no more balls can be removed.
                Find the minimal balls you have to insert to remove all the balls on the table. 
                If you cannot remove all the balls, output -1.

                Input: "WWRRBBWW", "WRBRW"
                Output: 2
                Explanation: WWRRBBWW -> WWRR[R]BBWW -> WWBBWW -> WWBB[B]WW -> WWWW -> empty
             */

            //Arrange
            var board = "WWRRBBWW";
            var hand = "WRBRW";
            var expected = 2;
            var target = new Hard();

            //act
            int actual = target.FindMinStep(board, hand);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
