using System.Collections.Generic;

namespace Day1
{
    public class ReportRepair
    {
        public int CalcProduct(List<int> inputs)
        {
            for (int i = 0; i < inputs.Count - 1; i++)
            {
                int firstNumber = inputs[i];

                for (int j = i + 1; j < inputs.Count; j++)
                {
                    int secondNumber = inputs[j];

                    if (firstNumber + secondNumber == 2020 && firstNumber != 299)
                    {
                        return firstNumber * secondNumber;
                    }

                }

            }

            return -1;
        }
    }
}
