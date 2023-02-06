using System.Text.RegularExpressions;

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
                if (s1[i] != s2[i])
                {
                    if (dif > 0
                        && s2[i] != s1[number])
                        return false;

                    dif++;
                    number = i;

                    if (!s2.Contains(s1[number]))
                        return false;
                }
                if (dif > 2)
                    return false;
            }
            return dif == 2 || dif == 0;
        }
    }
}