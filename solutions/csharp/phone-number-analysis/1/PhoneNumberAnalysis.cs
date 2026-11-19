public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string _phoneNumber = phoneNumber;
        string cutphoneNumber = _phoneNumber.Remove(0, 4);
        return (_phoneNumber.Remove(3) == "212", cutphoneNumber.Remove(3) == "555", cutphoneNumber.Remove(0, 4));
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => phoneNumberInfo.IsFake;
}
