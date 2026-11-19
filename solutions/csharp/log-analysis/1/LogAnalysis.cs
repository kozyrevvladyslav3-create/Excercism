public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string Divider)
    {
        string _Divider = Divider;
        return str.Remove(0, str.IndexOf(_Divider)+_Divider.Length);
    }
    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string FirstDivider, string LastDivider)
    {
        string _FirstDivider = FirstDivider;
        string _LastDivider = LastDivider;
        str = str.Remove(0, str.IndexOf(_FirstDivider)+_FirstDivider.Length);
        return str.Remove(str.IndexOf(_LastDivider));
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.Remove(0, str.IndexOf(": ")+2);
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        str = str.Remove(0, str.IndexOf("[")+1);
        return str.Remove(str.IndexOf("]"));
    }
}