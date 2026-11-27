public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        var result = new List<(int a, int b, int c)>();
        int c = 0;
        for (int a = 1; a < sum; a++)
        {
            for (int b = a + 1; b < sum; b++)
            {
                c = sum - a - b;
                if (a*a + b*b == c*c)
                {
                    result.Add((a, b, c));
                }
            }
        }
        return result;
    }
}