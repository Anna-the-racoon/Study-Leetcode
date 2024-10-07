namespace Leetcode.Logic;

public class SignOfProductOfArray
{
    public int ArraySign(int[] nums)
    {
        Array.Sort(nums);

        var result = true;
        foreach (var num in nums)
        {
            if (num > 0)
                return result ? 1 : -1;

            if (num == 0)
                return 0;

            result = result == false;
        }

        return result ? 1 : -1;
    }
}
