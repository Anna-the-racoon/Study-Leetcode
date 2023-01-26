namespace Leetcode
{
    public class LargestPerimeterTriangle
    {
        public int LargestPerimeter(int[] nums)
        {
            var perimeter = 0;

            for (var i = 0; i < nums.Length-2; i++)
            {
                for (var j = i+1; j < nums.Length-1; j++)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        if (nums[i] < nums[j] + nums[k]
                            && nums[j] < nums[i] + nums[k]
                            && nums[k] < nums[i] + nums[j])
                        {
                            perimeter = Math.Max(perimeter, (nums[i] + nums[j] + nums[k]));
                        }
                    }
                }
            }
            return perimeter;
        }
    }
}
