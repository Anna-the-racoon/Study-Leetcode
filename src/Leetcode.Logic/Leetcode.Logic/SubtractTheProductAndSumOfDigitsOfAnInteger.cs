namespace Leetcode.Logic;

public class SubtractTheProductAndSumOfDigitsOfAnInteger
{
    public int SubtractProductAndSum(int number)
    {
        var product = 1;
        var sum = 0;

        do
        {
            var element = number % 10;

            product *= element;

            sum += element;

            number /= 10;
        } while (number > 0);

        return product - sum;
    }
}
