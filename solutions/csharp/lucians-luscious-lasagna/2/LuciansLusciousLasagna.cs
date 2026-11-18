class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int TimeElapsed)
    {
        int _timeelapsed = TimeElapsed;
        return 40 - _timeelapsed;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int Layers)
    {
        int _layers = Layers;
        return _layers * 2;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int Layers, int TimeElapsed)
    {
        int _layers = Layers;
        int _timeelapsed = TimeElapsed;
        return _timeelapsed + _layers * 2;
    }
}
