using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class SeatID
    {
        // create 1023 open seats
        private readonly List<int> _openSeats = Enumerable.Range(0, 128 * 8 - 1).ToList();

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

                // remove claimed seat
                _openSeats.Remove(calculatedId);
            }

            return highestSeatId;
        }

        public int GetMySeat()
        {
            for (int i = 0; i < _openSeats.Count - 1; i++)
            {
                if (_openSeats[i + 1] - _openSeats[i] != 1)
                {
                    return _openSeats[i + 1];
                }
            }

            return -1;
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
