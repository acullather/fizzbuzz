using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using FizzBuzz;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzzMethodTest()
        {
            //Arrange
            int start = 1;
            int end = 100;
            bool completed = false;

            //Act
            completed = FizzBuzzClass.FizzBuzzMethod(start, end);

            //Assert
            Assert.IsTrue(completed);
        }

        [TestMethod]
        //[ExpectedException(typeof(FizzBuzzException))]
        public void FizzBuzzMethodInputTest()
        {
            //Arrange
            int start = 100;
            int end = 1;
            bool completed = false;

            //Act
            try
            {
                completed = FizzBuzzClass.FizzBuzzMethod(start, end);
            }
            catch (FizzBuzzException)
            {
            }

            //Assert
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            Assert.IsFalse(completed);
        }

        [TestMethod]
        public void FizzBuzzMethodConfigurableTest()
        {
            //Arrange
            int start = 1;
            int end = 6;
            string expectedOutput = "1 fizz buzz\r\n2\r\n3 fizz\r\n4\r\n5 buzz\r\n6 fizz\r\n";
            string actualOutput = string.Empty;
            List<ConfigurableDivisor> divs = new List<ConfigurableDivisor>();
            
            using (OutputMemoryStream oms = new OutputMemoryStream())
            {
                divs.Add(new ConfigurableDivisor() { 
                    Number = 3,
                    Message = "fizz"
                });
                divs.Add(new ConfigurableDivisor()
                {
                    Number = 5,
                    Message = "buzz"
                });

            //Act
                FizzBuzzClass.FizzBuzzMethod(start, end, divs, oms);
                actualOutput = System.Text.Encoding.Unicode.GetString(oms.ToArray());
            }

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
