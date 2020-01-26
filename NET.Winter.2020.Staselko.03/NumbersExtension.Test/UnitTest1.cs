using NUnit.Framework;
using System;

namespace NumbersExtension.Test
{
    public class NumberExtensionTests
    {
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001,0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        


        public void FindNthRoot_WithPossitivePowers_ExpectedResults(double number, int power, double accuracy,double expected)
        {
            Assert.AreEqual(expected, NewtonMethod.NumbersExtension.FindNthRoot(number, power, accuracy),accuracy);
        }

        [TestCase(-0.008, 3, 0.1, -0.2)]
        [TestCase(-0.125, 3, 0.1, -0.5)]
        public void FindNthRoot_WithNegativeNumbers_ExpectedResults(double number, int power, double accuracy, double expected)
        {
            Assert.AreEqual(expected, NewtonMethod.NumbersExtension.FindNthRoot(number, power, accuracy), accuracy);
        }

        [Test]
        public void FindNthRoot_WithAccuracyMoreEpsilon_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => NewtonMethod.NumbersExtension.FindNthRoot(-0.01, 2, 1.2),
               message: "accuracy cannot be more than epsilon");
        [Test]
        public void FindNthRoot_WithEvenPowerFromNegativeNumber_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => NewtonMethod.NumbersExtension.FindNthRoot(-0.01, 2,0.0001),
               message: "it is impossible to extract an even power root from a negative number.");
        [Test]
        public void FindNthRoot_WithNegativePower_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => NewtonMethod.NumbersExtension.FindNthRoot(0.001, -2, 0.0001),
               message: "power cannot be negative or zero.");

        [Test]
        public void FindNthRoot_WithNegativeAccuracy_ArgumentException() =>
           Assert.Throws<ArgumentException>(() => NewtonMethod.NumbersExtension.FindNthRoot( 0.01, 2,  -1),
               message: "accuracy cannot be negative.");
    }
}