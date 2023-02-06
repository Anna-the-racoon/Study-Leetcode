using System.Text.RegularExpressions;

namespace Leetcode
{
    public class OneStringSwapCanMakeStringsEqual
    {
        public bool AreAlmostEqual(string s1, string s2)
        {
            for (var i = 0; i < s1.Length; i++)
            {
                for (var j = 0; j < s1.Length; j++)
                {
                    var equals = s1.ToCharArray();

                    equals[i] = s1[j];
                    equals[j] = s1[i];

                    var result = true;
                    for (var k = 0; k < s2.Length; k++)
                    {
                        if (equals[k] != s2[k])
                            result = false;
                    }

                    if (result)
                        return true;
                }
            }
            return false;
        }
    }
}