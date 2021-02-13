using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    public class Toboggan
    {
        public double TreesEncounteredOnEachSlopes = 1;

        public int TotalTreesEncountered(List<string> inputs, int toRight = 1, int toBottom = 1)
        {
            int count = 0;
            int position = 0;

            // Jump (ignore) specific number of rows
            for (int i = toBottom; i < inputs.Count; i += toBottom)
            {
                string input = inputs[i];
                position += toRight;

                // When the end is reached restore position to the beginning of the list
                if (position >= input.Length)
                {
                    position -= input.Length;
                }

                char c = input[position];

                if (c == '#')
                {
                    ++count;
                }
            }

            TreesEncounteredOnEachSlopes *= count;
            return count;
        }
    }
}
