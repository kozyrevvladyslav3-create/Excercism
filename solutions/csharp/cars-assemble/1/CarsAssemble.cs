static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        (double zero, double onefour, double fiveeight, double nine, double ten) SuccessRate = (0.0, 1.0, 0.9, 0.8, 0.77);
        if (speed == 10)
        {
            return SuccessRate.ten;
        }
        else if (speed == 9)
        {
            return SuccessRate.nine;
        }
        else if (speed >= 5)
        {
            return SuccessRate.fiveeight;
        }
        else if (speed >= 1)
        {
            return SuccessRate.onefour;
        }
        else
        {
            return SuccessRate.zero;
        }
    }
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}
