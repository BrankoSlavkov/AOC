using AOC.Common;
using System;
using System.Collections.Generic;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputs = FileReader.GetInputsWithBlankLines<string>();
            PassportProcessor passportProcessor = new PassportProcessor();

            // 206
            Console.WriteLine($"Total Valid Passports: {passportProcessor.TotalValidPassports(inputs)}");
            Console.WriteLine($"Total Valid Passport Data: {passportProcessor.TotalValidPassportData(inputs)}");
        }
    }
}
