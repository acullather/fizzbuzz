using System;
using System.IO;

using FizzBuzzClass;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzzClass.FizzBuzzClass.FizzBuzz(1, 100);
            using (FileStream fs = new FileStream(@"c:\test\fizzbuzz.txt", FileMode.OpenOrCreate))
            {
                FizzBuzzClass.FizzBuzzClass.FizzBuzz(1, 10000, fs);
            }
            Console.ReadLine();
        }

    }

}
