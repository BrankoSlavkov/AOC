using System;
using AOC.Common;
using System.Collections.Generic;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();

            Toboggan toboggan = new Toboggan();
            inputs.GetInputs();

            Console.WriteLine($"Right 1, down 1 -> {toboggan.TotalTreesEncountered(inputs, 1)}");
            Console.WriteLine($"Right 3, down 1 -> {toboggan.TotalTreesEncountered(inputs, 3)}");
            Console.WriteLine($"Right 5, down 1 -> {toboggan.TotalTreesEncountered(inputs, 5)}");
            Console.WriteLine($"Right 7, down 1 -> {toboggan.TotalTreesEncountered(inputs, 7)}");
            Console.WriteLine($"Right 1, down 2 -> {toboggan.TotalTreesEncountered(inputs, 1, 2)}");

            Console.WriteLine($"Total: {toboggan.TreesEncounteredOnEachSlopes}");
        }
    }
}
