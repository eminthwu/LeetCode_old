using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using LeetCode.Easy;

namespace LeetCodeTest
{
    [TestClass]
    public class EasyTest
    {       

        [TestMethod]
        public void TwoSum()
        {
            /*
               Given an array of integers, return indices of the two numbers such that they add up to a specific target.
               You may assume that each input would have exactly one solution, and you may not use the same element twice.
            */


            //Arrange
            Easy target = new Easy();
            var given = new int[] { 3, 2, 4, 56, 9, 10, 8 };
            var specificTarget = 18;
            var expected = new int[] { 5, 6 };

            //Act
            int[] actual = target.TwoSum(given, specificTarget);


            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReverseInt()
        {
            //arrange
            var x = 1534236469;
            var expected = 0;
            var target = new Easy();

            //Act
            int actual = target.ReverseInt(x);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsPalindrome()
        {
            //arrange
            var x = 12321;
            var expected = true;
            var target = new Easy();         

            //Act
            bool actual = target.IsPalindrome(x);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
