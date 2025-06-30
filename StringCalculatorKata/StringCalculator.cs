using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string nums)
        {
            char[] delimeters = new char[100];
            delimeters[0] = '\n';
            delimeters[1] = ',';

            if (nums.StartsWith("//"))
            {
                for (int i = 2; i <= nums.IndexOf('\n'); i++)
                {
                    if (!delimeters.Contains(nums[i]))
                    {
                        delimeters[i] = nums[i];
                    }
                }
            }

            if (string.IsNullOrEmpty(nums))
            {
                return 0;
            }
            else if (nums.Length == 1)
            {
                return int.Parse(nums);
            }
            else
            {
                string[] numbersList = nums.Split(delimeters);

                int sum = 0;

                List<int> negatives = new List<int>();

                foreach (string currentNumber in numbersList)
                {
                    if(int.TryParse(currentNumber, out int number))
                    {
                        if (number < 0)
                        {
                            negatives.Add(number);
                        }
                        else
                        {
                            if (number > 1000)
                            {
                                continue;
                            }
                            else
                            {
                                sum += number;
                            }
                        }
                    }
                }

                if (negatives.Count == 0)
                {
                    return sum;
                }
                else
                {
                    throw new System.Exception($"Negative numbers not allowed: {string.Join(",", negatives)}");
                }
            }

        }
    }
}
