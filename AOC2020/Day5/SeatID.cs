using System;
using System.Collections.Generic;

namespace Day5
{
    class SeatID
    {
        public float GetHighestID(List<string> inputs)
        {
            int highestSeatId = int.MinValue;

            foreach (var id in inputs)
            {
                int calculatedId = FindSeatId(id);

                if (calculatedId > highestSeatId)
                {
                    highestSeatId = calculatedId;
                }
            }

            return highestSeatId;
        }


        static int FindSeatId(string id)
        {
            string binaryNumber = id
                .Replace('B', '1').Replace('F', '0')
                .Replace('R', '1').Replace('L', '0');

            return Convert.ToInt32(binaryNumber, 2);
        }
    }
}
