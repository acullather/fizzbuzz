using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FizzBuzz
{
    public static class FizzBuzzClass
    {
        #region Private Methods

        private static void ReverseNumbers(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }

        #endregion

        #region Public Methods

        public static bool FizzBuzzMethod(int startNum, int endNum)
        {
            if (startNum > endNum)
            {
                return false;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("{0} Fizz Buzz", i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("{0} Fizz", i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("{0} Buzz", i);
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }

            return true;
        }

        public static bool FizzBuzzMethod(int startNum, int endNum, IOutput output)
        {
            if (startNum > endNum)
            {
                //ReverseNumbers(ref startNum, ref endNum);
                // or
                throw new FizzBuzzException("Start number greater than end number");
            }

            string outputMessage = null;

            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //fizzbuzz
                    outputMessage = string.Format("{0} fizzbuzz\r\n", i);
                }
                else if (i % 3 == 0)
                {
                    //fizz
                    outputMessage = string.Format("{0} fizz\r\n", i);
                }
                else if (i % 5 == 0)
                {
                    //buzz
                    outputMessage = string.Format("{0} buzz\r\n", i);
                }
                else
                {
                    outputMessage = string.Format("{0}\r\n", i);
                }
                output.Write(outputMessage);
            }

            return true;
        }

        public static bool FizzBuzzMethod(int startNum, int endNum, ICollection<ConfigurableDivisor> divisors, IOutput output)
        {
            if (startNum > endNum)
            {
                // ReverseNumbers(ref startNum, ref endNum);
                // or
                throw new FizzBuzzException("Start number greater than end number");
            }

            string outputMessage = string.Empty;
            for (int i = startNum; i <= endNum; i++)
            {
                string combinedMsg = string.Empty;
                bool combined = false;
                foreach (ConfigurableDivisor div in divisors)
                {
                    if (i % div.Number == 0 ||
                        div.Number % i == 0)
                    {
                        if (combined)
                        {
                            combinedMsg = div.AppendMessage(combinedMsg, combined: true);
                        }
                        else
                        {
                            combinedMsg = div.AppendMessage(combinedMsg, numberTested: i);
                            combined = true;
                        }
                    }
                }
                if (string.IsNullOrEmpty(combinedMsg))
                {
                    combinedMsg = i.ToString();
                }
                outputMessage += combinedMsg + "\r\n";
            }

            output.Write(outputMessage);
            return true;
        }

        #endregion
    }
}
