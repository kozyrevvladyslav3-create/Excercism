static class LogLine
{
    public static string Message(string logLine)
    {
        string _logLine = logLine;
        if (_logLine.StartsWith("[ERROR]:"))
        {
            _logLine = _logLine.Remove(0, 8);
            _logLine = _logLine.Trim();
            return _logLine;
        }
        else if (_logLine.StartsWith("[WARNING]:"))
        {
            _logLine = _logLine.Remove(0, 10);
            _logLine = _logLine.Trim();
            return _logLine;
        }
        else if (_logLine.StartsWith("[INFO]:"))
        {
            _logLine = _logLine.Remove(0, 7);
            _logLine = _logLine.Trim();
            return _logLine;
        }
        else
        {
            return null;
        }
    }

    public static string LogLevel(string logLine)
    {
        string _logLine = logLine;
        if (_logLine.StartsWith("[ERROR]:"))
        {
            return "error";
        }
        else if (_logLine.StartsWith("[WARNING]:"))
        {
            return "warning";
        }
        else if (_logLine.StartsWith("[INFO]:"))
        {
            return "info";
        }
        else
        {
            return null;
        }
    }

    public static string Reformat(string logLine)
    {
        string _logLine = logLine;
        if (_logLine.StartsWith("[ERROR]:"))
        {
            _logLine = _logLine.Remove(0, 8);
            _logLine = _logLine.Trim();
            return $"{_logLine} (error)";
        }
        else if (_logLine.StartsWith("[WARNING]:"))
        {
            _logLine = _logLine.Remove(0, 10);
            _logLine = _logLine.Trim();
            return $"{_logLine} (warning)";
        }
        else if (_logLine.StartsWith("[INFO]:"))
        {
            _logLine = _logLine.Remove(0, 7);
            _logLine = _logLine.Trim();
            return $"{_logLine} (info)";
        }
        else
        {
            return null;
        }
    }
}
