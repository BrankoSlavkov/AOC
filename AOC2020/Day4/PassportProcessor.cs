using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class PassportProcessor
    {
        public int TotalValidPassports(List<string> inputs)
        {
            List<string> passportParts = new List<string>();
            int count = 0;

            for (int i = 0; i < inputs.Count; i++)
            {
                string line = inputs[i];

                if (!string.IsNullOrWhiteSpace(line))
                {
                    passportParts.Add(line);
                }
                else
                {
                    string passport = string.Join(" ", passportParts);

                    if (isValidPassword(passport))
                    {
                        count++;
                    }

                    passportParts.Clear();
                }
            }

            static bool isValidPassword(string line)
            {
                bool isValid =
                    line.Contains("byr") && line.Contains("iyr") && line.Contains("eyr") &&
                    line.Contains("hgt") && line.Contains("hcl") && line.Contains("ecl") &&
                    line.Contains("pid");

                return isValid;
            }

            return count;
        }



    }
}
