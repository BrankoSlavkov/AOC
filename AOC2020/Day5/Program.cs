using AOC.Common;
using System;
using System.Collections.Generic;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = FileReader.GetInputs<string>();
            SeatID seatId = new SeatID();

            Console.WriteLine(seatId.GetHighestID(inputs));
        }
    }
}
