using System;
using System.IO;

using FizzBuzz;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            using (OutputFileStream os = new OutputFileStream(@"c:\test\fizzbuzz.txt", FileMode.OpenOrCreate))
            {
                FizzBuzzClass.FizzBuzzMethod(1, 10000, os);
            }
            Console.WriteLine("Finished.");
            Console.ReadLine();
        }

    }

}
