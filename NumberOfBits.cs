using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class NumberOfBits
    {
        public int HammingWeight(uint number)
        {
            var sum = 0;

            foreach (var bit in number.ToString())
            {
                if (bit == '1')
                    sum += 1;
            }

            return sum;
        }
    }
}
