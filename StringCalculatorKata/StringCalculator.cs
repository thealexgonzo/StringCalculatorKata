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

            return int.Parse(nums);
        }
    }
}
