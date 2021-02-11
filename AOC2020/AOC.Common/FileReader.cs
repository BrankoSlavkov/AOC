using System;
using System.Collections.Generic;
using System.IO;

namespace AOC.Common
{
    public static class FileReader
    {
        public static IEnumerable<T> GetInputs<T>(this List<T> inputs)
        {
            // File should exist in project directory
            string filePath = $"../../../inputs.txt";

            if (File.Exists(filePath))
            {
                using var reader = File.OpenText(filePath);
                string line = string.Empty;

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        T readLine = (T)Convert.ChangeType(line, typeof(T));
                        inputs.Add(readLine);
                    }
                }
            }

            return inputs;
        }

    }
}
