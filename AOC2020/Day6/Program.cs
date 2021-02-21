using AOC.Common;
using System;
using System.Collections.Generic;

namespace Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = FileReader.GetInputsWithBlankLines<string>();
            CountYes totalYes = new CountYes();

            Console.WriteLine(totalYes.GetTotalYes(inputs));
        }
    }
}
