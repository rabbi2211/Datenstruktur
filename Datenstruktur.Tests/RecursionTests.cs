using NUnit.Framework;
using System;

namespace Datenstruktur.Tests
{
    [TestFixture]
    public class RecursionTests
    {
        Recursion sut = null;
        Memoization sutMe = null;
        [OneTimeSetUp]
        public void Init()
        {
            sut = new Recursion();
            sutMe = new Memoization();
        }
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(100, 1)]
        [TestCase(999, 27)]
        [TestCase(9999, 36)]
        [TestCase(9909, 27)]
        public void Validate_Digit_Sum(int numberToTest, int expectedOutput)
        {

            var result = sut.DigitSum_Recursive(numberToTest);
            Assert.That(result, Is.EqualTo(expectedOutput));


        }

        [Test]
        [TestCase(new Int32[] { 5, 2, 8 }, false)]
        [TestCase(new Int32[] { 1, 2, 3 }, true)]
        public void Validate_Elements_In_Sequence(Int32[] inputArray, bool expectedResult)
        {

            var result = sut.ElementsInSequence_Recursive(inputArray, inputArray.Length - 1);
        }

        [Test]
        [TestCase(3, 4)]
        [TestCase(4, 8)]
        [TestCase(5, 13)]
        [TestCase(50, 20365011074), Category("Stress Case")]
        public void GetFibbonacciSeries(int inputNumber, long expectedOutput)
        {
            var result = sut.FibonacciSeries_Recursive(inputNumber);
        }


        [Test]
        [TestCase(3, 4)]
        [TestCase(4, 8)]
        [TestCase(5, 13)]
        [TestCase(50, 20365011074), Category("Stress Case")]
        [TestCase(100, 4224848179261915075), Category("Stress Case")]



        public void GetFibbonacciSeries_Memotized(int inputNumber, long expectedOutput)
        {
            var result = sutMe.FibbonacciSeries_Memotized(inputNumber, new System.Collections.Generic.Dictionary<int, long>());
        }

    }

}