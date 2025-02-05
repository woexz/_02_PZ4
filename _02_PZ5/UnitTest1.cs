using System;
using NUnit.Framework;

namespace _02_PZ5
{
    internal class Program
    {
        
    }

    public class NumberUtils
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }

    [TestFixture]
    public class NumberUtilsTests
    {
        [Test]
        public void Test_PositiveEvenNumbers()
        {
            Assert.IsTrue(NumberUtils.IsEven(2));
            Assert.IsTrue(NumberUtils.IsEven(4));
            Assert.IsTrue(NumberUtils.IsEven(6));
        }

        [Test]
        public void Test_NegativeOddNumbers()
        {
            Assert.IsFalse(NumberUtils.IsEven(-3));
            Assert.IsFalse(NumberUtils.IsEven(-5));
        }

        [Test]
        public void Test_Zero()
        {
            Assert.IsTrue(NumberUtils.IsEven(0));
        }
    }
}