using System;
using LogProcessing;
class Program
{
    static void Main(string[] args)
    {
        // Reg.Rege();


        LogParser log = new LogParser();
        Console.WriteLine(log.IsValidLine("[INF]Application Started"));
        string[] arr = log.SplitLogLine("\n[INF]User login<***>Session created<====>Access granted");
        foreach(string x in arr)
        {
            Console.WriteLine($"\"{x}\"");
        }
        Console.WriteLine("\nCount of Password: "+log.CountQuotedPasswords("[INF]\"password Application\" \"PASSword PASSWORD\" Started"));
    }
}