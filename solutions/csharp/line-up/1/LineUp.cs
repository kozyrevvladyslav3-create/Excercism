public static class LineUp
{
    public static string Format(string name, int number)
    {
        string end = "";
        string _number = number.ToString();
        if (_number.EndsWith("11") || _number.EndsWith("12") || _number.EndsWith("13"))
        {
            end = "th";
        }
        else if (_number.EndsWith("1"))
        {
            end = "st";
        }
        else if (_number.EndsWith("2"))
        {
            end = "nd";
        }
        else if (_number.EndsWith("3"))
        {
            end = "rd";
        }
        else
        {
            end = "th";
        }
        return $"{name}, you are the {number}{end} customer we serve today. Thank you!";
    }
}
