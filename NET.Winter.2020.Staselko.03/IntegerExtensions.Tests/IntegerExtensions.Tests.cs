using NUnit.Framework;
using System;
using static FindGcd.IntegerExtensions;
namespace IntegerExtensions.Tests
{
    public class Tests
    {
        #region GetGcdByEuclidean
        [TestCase(new[] { 100, 60, 40 }, ExpectedResult = 20)]
        [TestCase(0, 0, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 1)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(0, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 0, ExpectedResult = 1)]
        [TestCase(18, 3, 9, 6, ExpectedResult = 3)]
        [TestCase(3, 15, ExpectedResult = 3)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(-10, 35, 90, 55, -105, ExpectedResult = 5)]
        [TestCase(1, 213124, -54654, -123124, 65765, 44444, -7, 1234567, int.MaxValue, ExpectedResult = 1)]
        [TestCase(18, 0, ExpectedResult = 18)]
        [TestCase(12, 21, 91, 17, 0, int.MaxValue, ExpectedResult = 1)]
        [TestCase(3, -3, 3, ExpectedResult = 3)]
        [TestCase(-7, -7, ExpectedResult = 7)]
        [TestCase(123413, 943578, 123413, 943578, 943578, int.MaxValue, ExpectedResult = 1)]
        public int GetGcdByEuclidean_WithSeveralNumbers(params int[] array) => GetGcdByEuclidean(array);

        [Test]
        public void GetGcdByEuclidean_WithArrayOfTwoZeros_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0),
               message: "Two numbers cannot be 0 at the same time.");
        [Test]
        public void GetGcdByEuclidean_WithArrayOfThreeZeros_ArgumentException() =>
         Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0),
             message: "Three numbers cannot be 0 at the same time.");
        [Test]
        public void GetGcdByEuclidean_WithArrayOfAllZeros_ArgumentException() =>
        Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(0, 0, 0, 0, 0, 0),
            message: " Numbers cannot be 0 at the same time.");
        [Test]
        public void GetGcdByEuclidean_WithIntMinValue_ArgumentException() =>
        Assert.Throws<ArgumentException>(() => GetGcdByEuclidean(1, 2, 3, int.MinValue),
            message: " Numbers cannot to be int.MinValue");
        #endregion

        #region GetGcdByStein
        [TestCase(new[] { 100, 60, 40 }, ExpectedResult = 20)]
        [TestCase(5, 5, 5, ExpectedResult = 5)]
        [TestCase(100, 60, 16, ExpectedResult = 4)]
        [TestCase(100, -100, -50, ExpectedResult = 50)]
        [TestCase(1, 2, 3, ExpectedResult = 1)]
        [TestCase(-1, -2, -3, ExpectedResult = 1)]
        [TestCase(0, 0, 1, 0, ExpectedResult = 1)]
        [TestCase(0, 0, -1, ExpectedResult = 1)]
        [TestCase(0, 1, 0, 0, ExpectedResult = 1)]
        [TestCase(18, 3, 9, 6, ExpectedResult = 3)]
        [TestCase(3, 15, ExpectedResult = 3)]
        [TestCase(15, 5, 45, ExpectedResult = 5)]
        [TestCase(-10, 35, 90, 55, -105, ExpectedResult = 5)]
        [TestCase(1, 213124, -54654, -123124, 65765, 44444, -7, 1234567, int.MaxValue, ExpectedResult = 1)]
        [TestCase(18, 0, ExpectedResult = 18)]
        [TestCase(12, 21, 91, 17, 0, int.MaxValue, ExpectedResult = 1)]
        [TestCase(3, -3, 3, ExpectedResult = 3)]
        [TestCase(-7, -7, ExpectedResult = 7)]
        [TestCase(123413, 943578, 123413, 943578, 943578, int.MaxValue, ExpectedResult = 1)]

        public int GetGcdByStein_WithSevevdvralNumbers(params int[] array) => GetGcdByStein(array);

        [Test]
        public void GetGcdByStein_WithArrayOfTwoZeros_ArgumentException() =>
          Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0),
              message: "Two numbers cannot be 0 at the same time.");
        [Test]
        public void GetGcdByStein_WithArrayOfThreeZeros_ArgumentException() =>
         Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0),
             message: "Three numbers cannot be 0 at the same time.");
        [Test]
        public void GetGcdByStein_WithArrayOfAllZeros_ArgumentException() =>
        Assert.Throws<ArgumentException>(() => GetGcdByStein(0, 0, 0, 0, 0, 0),
            message: " Numbers cannot be 0 at the same time.");
        [Test]
        public void GetGcdByStein_WithIntMinValue_ArgumentException() =>
        Assert.Throws<ArgumentException>(() => GetGcdByStein(1, 2, 3, int.MinValue),
            message: " Numbers cannot to be int.MinValue");
        #endregion
    }
}