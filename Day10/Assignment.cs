using System;
using System.Text.RegularExpressions;
namespace LogProcessing;
class LogParser
{
    private readonly string validLineRegexPattern=@"^\[(TRC|DBG|INF|WRN|ERR|FTL)]";
    private readonly string splitLineRegexPattern=@"\<[\*^=]+>";
    private readonly string quotedPasswordRegexPattern="";
    private readonly string endOfLineRegexPattern="";
    private readonly string weakPasswordRegexPattern="";

    public bool IsValidLine(string text)
    {
        return Regex.IsMatch(text,validLineRegexPattern);
    }
    public string[] SplitLogLine(string text)
    {
        string[] arr = Regex.Split(text,splitLineRegexPattern);
        return arr;
    }
    public int CountQuotedPasswords(string lines)
    {
        int count=0;
        lines=lines.ToLower();
        MatchCollection m = Regex.Matches(lines,@"");
        foreach(Match x in m) count++;
        return count;
    }
}