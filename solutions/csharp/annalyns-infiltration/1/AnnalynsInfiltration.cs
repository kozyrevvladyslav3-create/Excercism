static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        bool _knightIsAwake = knightIsAwake;
        return !_knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        bool _knightIsAwake = knightIsAwake;
        bool _archerIsAwake = archerIsAwake;
        bool _prisonerIsAwake = prisonerIsAwake;
        return _knightIsAwake || _archerIsAwake || _prisonerIsAwake;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        bool _archerIsAwake = archerIsAwake;
        bool _prisonerIsAwake = prisonerIsAwake;
        return !_archerIsAwake && _prisonerIsAwake;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        bool _knightIsAwake = knightIsAwake;
        bool _archerIsAwake = archerIsAwake;
        bool _prisonerIsAwake = prisonerIsAwake;
        bool _petDogIsPresent = petDogIsPresent;
        return (!_archerIsAwake && _petDogIsPresent) || (!_knightIsAwake && !_archerIsAwake && _prisonerIsAwake);
    }
}
