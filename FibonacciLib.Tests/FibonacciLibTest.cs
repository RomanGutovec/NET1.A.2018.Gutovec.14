using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FibonacciLib.Tests
{
    [TestFixture]
    public class FibonacciLibTest
    {
        [TestCase(3, new long[] { 0, 1, 1 })]
        [TestCase(10, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 })]
        [TestCase(12, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 })]
        [TestCase(16, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 })]
        [TestCase(17, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987 })]
        [TestCase(19, new long[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584 })]
        public void FindFibonacciNumbersTest_InputDifferentAmounts(int amount, long[] expected)
        {
            CollectionAssert.AreEqual(expected, FibonacciLib.Fibonacci.FindFibonacciNumbers(amount));
        }

        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(1)]
        public void FindFibonacciNumbersTest_InputIncorrectData_ArgumentException(int amount)
        => Assert.Throws<ArgumentException>(() => FibonacciLib.Fibonacci.FindFibonacciNumbers(amount));
    }
}
