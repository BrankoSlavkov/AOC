using AOC.Common;
using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputs = new List<int>();

            inputs.GetInputs();

            ReportRepair reportRepair = new ReportRepair();

            Console.WriteLine(reportRepair.CalcProduct2Numbers(inputs));
            Console.WriteLine(reportRepair.CalcProduct3Numbers(inputs));
        }
    }
}
