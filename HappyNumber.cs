namespace Leetcode
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            if (n < 0 )
                return false;

            var result = n;
            var resultList = new List<int>();
            do
            {
                result = HappinessCalculation(result);

                if (resultList.Contains(result))
                {
                    return false;
                }
                resultList.Add(result);

            } while (result != 1);

            return true;
        }

        public int HappinessCalculation(int n)
        {
            var result = 0;

            while (n > 0)
            {
                var element = n % 10;

                result += element * element;

                n /= 10;
            }

            return result;
        }
    }
}