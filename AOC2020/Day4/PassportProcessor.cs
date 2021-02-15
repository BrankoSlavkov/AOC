using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day4
{
    class PassportProcessor
    {

        #region Public Methods
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

                    if (isValidPasspot(passport))
                    {
                        count++;
                    }

                    passportParts.Clear();
                }
            }

            static bool isValidPasspot(string line)
            {
                bool isValid =
                    line.Contains("byr") && line.Contains("iyr") && line.Contains("eyr") &&
                    line.Contains("hgt") && line.Contains("hcl") && line.Contains("ecl") &&
                    line.Contains("pid");

                return isValid;
            }

            return count;
        }

        public int TotalValidPassportData(List<string> inputs)
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

                    if (IsValidData(passport))
                    {
                        count++;
                    }

                    passportParts.Clear();
                }
            }

            return count;
        }
        #endregion

        #region Private Methods
        private static bool IsValidData(string line)
        {
            Regex byrRegex = CreateRegex(@"byr:(19[2-9][0-9]|200[0-2])");
            Regex iyrRegex = CreateRegex(@"iyr:(201[0-9]|2020)");
            Regex eyrRegex = CreateRegex(@"eyr:(202[0-9]|2030)");
            Regex hgtRegex = CreateRegex(@"hgt:\d+(cm|in)");
            Regex hclRegex = CreateRegex(@"hcl:#[0-9a-f]{6}");
            Regex eclRegex = CreateRegex(@"ecl:(amb|blu|brn|gry|grn|hzl|oth)");
            Regex pidRegex = CreateRegex(@"pid:\d{9}");

            bool isValidGht;

            if (hgtRegex.IsMatch(line))
            {
                string matchHgt = hgtRegex.Match(line).Value;
                isValidGht = IsValidHgt(matchHgt);
            }
            else
            {
                return false;
            }


            bool isValid = byrRegex.IsMatch(line) && iyrRegex.IsMatch(line) && eyrRegex.IsMatch(line) && isValidGht
                && hclRegex.IsMatch(line) && eclRegex.IsMatch(line) && pidRegex.IsMatch(line);

            return isValid;
        }

        private static Regex CreateRegex(string pattern)
        {
            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private static bool IsValidHgt(string line)
        {
            bool isValid;
            string resultString = Regex.Match(line, @"\d+").Value;
            int hgt = int.Parse(resultString);

            if (line.Contains("cm"))
            {
                isValid = hgt >= 150 && hgt <= 193;
            }
            else
            {
                isValid = hgt >= 59 && hgt <= 76;
            }

            return isValid;
        }

        #endregion
    }
}

