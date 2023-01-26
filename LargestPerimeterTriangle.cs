namespace Leetcode
{
    public class LargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] nums)
        {
            var perimeter = 0;

            Array.Sort(nums);

            for (var i = nums.Length-1; i >= 2; i--)
            {
                if (nums[i] < nums[i - 1] + nums[i - 2])
                {
                    perimeter = Math.Max(perimeter, (nums[i] + nums[i - 1] + nums[i - 2]));
                }
            }
            return perimeter;
        }
    }
}