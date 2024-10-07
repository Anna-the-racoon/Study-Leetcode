namespace Leetcode.Logic;

public class NumberOfBits
{
    public int HammingWeight(uint number)
    {
        var sum = 0;

        while (number > 0)
        {
            if (number % 2 != 0)
                sum++;

            number /= 2;
        };

        return sum;
    }

    public int HammingWeightString(uint number)
    {
        return Convert.ToString(number, 2).Count(bit => bit == '1');
    }
}
