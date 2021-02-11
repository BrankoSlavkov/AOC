using System;
using System.Collections.Generic;

namespace Day2
{
    class PasswordPhilosophy
    {

        public int TotalValidPasswords { get; set; }
        public int TotalValidPasswordsPart2 { get; set; }

        public PasswordPhilosophy(List<string> inputs)
        {
            TotalValidPasswords = GetTotalValidPasswords(inputs);
            TotalValidPasswordsPart2 = GetTotalValidPasswordsPart2(inputs);
        }

        private static int GetTotalValidPasswords(List<string> inputs)
        {
            int totalValidPasswords = 0;

            foreach (var input in inputs)
            {
                int totalAppearanceCount = 0;
                string[] parts = input.Split(' ');
                string[] appears = parts[0].Split('-');

                int from = int.Parse(appears[0]);
                int to = int.Parse(appears[1]);

                char character = char.Parse(parts[1].Remove(parts[1].Length - 1));
                string sequence = parts[2];


                for (int i = 0; i < sequence.Length; i++)
                {
                    if (sequence[i] == character)
                    {
                        totalAppearanceCount += 1;
                    }
                }

                if (from <= totalAppearanceCount && totalAppearanceCount <= to)
                {
                    totalValidPasswords += 1;
                }
            }

            return totalValidPasswords >= 0 ? totalValidPasswords : -1;
        }


        private static int GetTotalValidPasswordsPart2(List<string> inputs)
        {
            int totalValidPasswords = 0;

            foreach (var input in inputs)
            {
                string[] parts = input.Split(' ');
                string[] appears = parts[0].Split('-');

                int from = int.Parse(appears[0]) - 1;
                int to = int.Parse(appears[1]) - 1;

                char character = char.Parse(parts[1].Remove(parts[1].Length - 1));
                string sequence = parts[2];


                if (from < 0 && to >= sequence.Length)
                {
                    continue;
                }

                if (sequence[from] == character && sequence[to] != character ||
                    sequence[from] != character && sequence[to] == character)
                {
                    totalValidPasswords += 1;
                }

            }

            return totalValidPasswords >= 0 ? totalValidPasswords : -1;
        }

    }
}
