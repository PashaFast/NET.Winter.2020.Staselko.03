using NUnit.Framework;
using System;
using System.Linq;
using static FilterArray.ArrayExtension;
using static ArrayCreation.ArrayGenerator;

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
            Assert.AreEqual(expected, FilterArrayByKey(array,digit));
        }

        [Test]
        public void FilterArrayByKey_WithEmptyArray_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => FilterArrayByKey(new int[0], 0),
               message: "Array cannot be empty!");

        [Test]
        public void FilterArrayByKey_WithNullArray_ArgumentNullException() =>
          Assert.Throws<ArgumentNullException>(() => FilterArrayByKey(null, 0),
              message: "Array cannot be null");

        [Test]
        public void FilterArrayByKey_WithNegativeDigit_ArgumentOutOfRangeException() =>
         Assert.Throws<ArgumentOutOfRangeException>(() => FilterArrayByKey(new int[] { 1, 2 }, -1),
             message: "Digit cannot be negative");

        [TestCase(4)]
        public void FilterArrayByKey_BigArray_Somethig(int key)
        {
            //int[] source = Enumerable.Repeat(145, 100_000_000).ToArray();
            //int[] act = FilterArrayByKey(source, 1);
            //Assert.AreEqual(source, act);
            int[] source = GetArrayWithDigit(100_000_000, key);
            int[] act = FilterArrayByKey(source, key);
            Assert.AreEqual(source, act); 
            
            
        }
    }
}