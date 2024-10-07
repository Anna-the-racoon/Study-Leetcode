namespace Leetcode
{
    public class NearestPoint
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            var item = -1;
            var distance = Int32.MaxValue;

            for (int i = 0; i < points.Length; i++)
            {
                if (x != points[i][0] && y != points[i][1]) 
                    continue;

                var tempDistance = Math.Abs(x - points[i][0]) + Math.Abs(y - points[i][1]);

                if (tempDistance >= distance)
                    continue;

                distance = tempDistance;
                item = i;
            }
            return item;
        }
    }
}
