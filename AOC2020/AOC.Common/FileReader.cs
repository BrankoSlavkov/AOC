using System;
using System.Collections.Generic;
using System.IO;

namespace AOC.Common
{
    public static class FileReader
    {
        // File should exist in project directory
        private const string _filePath = "../../../inputs.txt";
        public static List<T> GetInputs<T>(bool isReadWithoutNewLine = true)
        {
            List<T> inputs = new List<T>();

            if (File.Exists(_filePath))
            {
                using var reader = File.OpenText(_filePath);
                string line = string.Empty;

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (isReadWithoutNewLine && string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }

                    T readLine = (T)Convert.ChangeType(line, typeof(T));
                    inputs.Add(readLine);
                }
            }

            return inputs;
        }
    }
}
