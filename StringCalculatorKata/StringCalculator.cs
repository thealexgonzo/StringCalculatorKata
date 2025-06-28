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
                string[] numbers = nums.Split('\n', ',');

                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != null)
                    {
                        sum += int.Parse(numbers[i]);
                    }
                    else
                    {
                        sum += 0;
                    }
                }

                return sum;
            }

        }
    }
}
