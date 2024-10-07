namespace Leetcode
{
    public class OneStringSwapCanMakeStringsEqual
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            var dif = 0;
            var number = 0;
            for (var i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[i]) 
                    continue;

                if (dif > 2)
                    return false;

                if (dif > 0
                    && s2[i] != s1[number]
                    && s1[i] != s2[number])
                    return false;

                dif++;
                number = i;
            }
            return dif == 2 || dif == 0;
        }
    }
}