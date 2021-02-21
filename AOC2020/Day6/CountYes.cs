using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class CountYes
    {
        public int GetTotalYes(List<string> inputs)
        {
            int total = 0;
            List<string> answerParts = new List<string>();

            for (int i = 0; i < inputs.Count; i++)
            {
                string line = inputs[i];

                if (!string.IsNullOrWhiteSpace(line))
                {
                    answerParts.Add(line);
                }
                else
                {
                    string totalAnswersPerPerson = string.Join("", answerParts);
                    total += totalAnswersPerPerson.Distinct().Count();

                    answerParts.Clear();
                }
            }

            return total;

        }
    }
}
