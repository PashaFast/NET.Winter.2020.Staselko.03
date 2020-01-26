using NUnit.Framework;
using FilterArray;
using System;
using System.Linq;

namespace ArrayExtension.Tests
{
   
    public class ArrayExtensionTests
    {
        [TestCase(new[] { 2212332, 1405644, 1236674 }, 0, new[] { 1405644 })]
        [TestCase(new[] { 53, 71, -24, 1001, 32, 1005 }, 2, new[] { -24, 32 })]
        [TestCase(new[] { -27, 173, 371132, 7556, 7243, 10017 }, 7, new[] { -27, 173, 371132, 7556, 7243, 10017 })]
        [TestCase(new[] { 7, 2, 5, 5, -1, -1, 2 }, 9, new int[0])]

        public void FilterArrayByKey_WithPossitivePowers_ExpectedResults(int[] array, int digit, int[] expected)
        {
            Assert.AreEqual(expected, FilterArray.ArrayExtension.FilterArrayByKey(array,digit));
        }

        [Test]
        public void FilterArrayByKey_WithEmptyArray_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => FilterArray.ArrayExtension.FilterArrayByKey(new int[0], 0),
               message: "Array cannot be empty!");

        [Test]
        public void FilterArrayByKey_WithNullArray_ArgumentNullException() =>
          Assert.Throws<ArgumentNullException>(() => FilterArray.ArrayExtension.FilterArrayByKey(null, 0),
              message: "Array cannot be null");

        [Test]
        public void FilterArrayByKey_WithNegativeDigit_ArgumentOutOfRangeException() =>
         Assert.Throws<ArgumentOutOfRangeException>(() => FilterArray.ArrayExtension.FilterArrayByKey(new int[] { 1, 2 }, -1),
             message: "Digit cannot be negative");

        [Test]
        public void FilterArrayByKey_BigArray_Somethig()
        {
            int[] source = Enumerable.Range(0, 100).ToArray();
            int[] act = FilterArray.ArrayExtension.FilterArrayByKey(source,1);
            int[] expected = new int[] { 1, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 31, 41, 51, 61, 71, 81, 91 };
            Assert.AreEqual(expected, act);
        }

    }
}