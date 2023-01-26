namespace Leetcode
{
    public class SignOfProductOfArray
    {
        public int ArraySign(int[] nums)
        {
            Array.Sort(nums);

            var number = 0;
            foreach (var num in nums)
            {
                if (num > 0)
                    return number%2 == 0 ? 1 : -1;

                if (num == 0)
                    return 0;

                number++;
            }

            return number % 2 == 0 ? 1 : -1;
        }
    }
}
