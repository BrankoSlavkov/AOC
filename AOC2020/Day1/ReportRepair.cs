using System.Collections.Generic;

namespace Day1
{
    public class ReportRepair
    {
        public int CalcProduct2Numbers(List<int> inputs)
        {
            for (int i = 0; i < inputs.Count - 1; i++)
            {
                int firstNumber = inputs[i];

                for (int j = i + 1; j < inputs.Count; j++)
                {
                    int secondNumber = inputs[j];

                    if (firstNumber + secondNumber == 2020 &&
                        IsNotUsed(firstNumber) && IsNotUsed(secondNumber))
                    {
                        return firstNumber * secondNumber;
                    }

                }

            }

            static bool IsNotUsed(int number) => number != 299 && number != 1721;

            return -1;
        }

        public int CalcProduct3Numbers(List<int> inputs)
        {
            for (int i = 0; i < inputs.Count - 2; i++)
            {
                int firstNumber = inputs[i];

                for (int j = i + 1; j < inputs.Count - 1; j++)
                {
                    int secondNumber = inputs[j];

                    for (int k = j + 1; k < inputs.Count; k++)
                    {
                        int thirdNumber = inputs[k];

                        if (firstNumber + secondNumber + thirdNumber == 2020 &&
                            IsNotUsed(firstNumber) &&
                            IsNotUsed(secondNumber) &&
                            IsNotUsed(thirdNumber))
                        {
                            return firstNumber * secondNumber * thirdNumber;
                        }
                    }

                }

            }

            static bool IsNotUsed(int number) => number != 979 && number != 366 && number != 675;

            return -1;
        }


    }
}
