using System;
using System.IO;

namespace FizzBuzzClass
{
    public static class FizzBuzzClass
    {
        public static bool FizzBuzz(int startNum, int endNum)
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

        public static bool FizzBuzz(int startNum, int endNum, Stream streamOutput)
        {
            if (startNum > endNum)
            {
                return false;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    //fizzbuzz

                    streamOutput.Write(string.Format("{0} fizzbuzz", i));
                }
                else if (i % 3 == 0)
                {
                    //fizz
                    streamOutput.Write(string.Format("{0} fizz", i));
                }
                else if (i % 5 == 0)
                {
                    //buzz
                    streamOutput.Write(string.Format("{0} buzz", i));
                }
                else
                {
                    Console.WriteLine("{0}", i);
                }
            }

            return true;
        }
    }
}
