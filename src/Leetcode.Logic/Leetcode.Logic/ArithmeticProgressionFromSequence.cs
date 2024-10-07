namespace Leetcode.Logic;

public class ArithmeticProgressionFromSequence
{
    public bool CanMakeArithmeticProgression(int[] arr)
    {
        Array.Sort(arr);

        var d = arr[1] - arr[0];

        for (var i = 1; i < arr.Length - 1; i++)
        {
            if ((arr[i + 1] - arr[i]) != d)
                return false;
        }

        return true;
    }

}
