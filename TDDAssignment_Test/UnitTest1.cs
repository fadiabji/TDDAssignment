using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDAssignment;

namespace TDDAssignment_Test
{
    [TestClass]
    public class UnitTest1
    {
        MathCompnent obj = new MathCompnent();
        
        [TestMethod]
        public void AddTwoIntegersReturnsSum()
        {
            int expected = 20;
            int actual = obj.AddNumber(10, 10);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubstractTwoIntegersReturnDifference()
        {
            Assert.AreEqual(-5, obj.GetDifference(10,15));
        }

        [TestMethod]
        public void PositiveNumberReturnsPositive()
        {
            Assert.AreEqual("Positive", obj.GetNumberSign(100));
        }

        [TestMethod]
        public void NegativeNumberReturnsNegative()
        {
            Assert.AreEqual("Negative", obj.GetNumberSign(-100));
        }

        [TestMethod]
        public void ZeroNumberReturnsZero()
        {
            Assert.AreEqual("Zero", obj.GetNumberSign(0));
        }

    }
}
