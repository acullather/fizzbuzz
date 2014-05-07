using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzzTest()
        {
            //Arrange
            int start = 1;
            int end = 100;
            bool completed = false;

            //Act
            completed = FizzBuzzClass.FizzBuzzClass.FizzBuzz(start, end);

            //Assert
            Assert.IsTrue(completed);
        }

        [TestMethod]
        public void FailTest()
        {
            int start = 100;
            int end = 1;
            bool completed = false;

            completed = FizzBuzzClass.FizzBuzzClass.FizzBuzz(start, end);

            Assert.IsFalse(completed);
        }
    }
}
