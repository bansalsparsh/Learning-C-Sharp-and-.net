using System;
using System.Collections;
namespace DialingCodesApp;
public static class DialingCodes
{
    public static Dictionary<int, string> dict = new Dictionary<int, string>();
    
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        Dictionary<int, string> d1 = new Dictionary<int, string>();
        return d1;
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
        dict.Add(1, "United States of America");
        dict.Add(55, "Brazil");
        dict.Add(91, "India");
        return dict;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        Dictionary<int, string> temp = GetEmptyDictionary();
        temp.Add(countryCode,countryName);
        return temp;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        existingDictionary.Add(countryCode,countryName);
        return existingDictionary;
    }

    public static string GetCountryNameFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary[countryCode];
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if (CheckCodeExists(existingDictionary, countryCode)) existingDictionary[countryCode]=countryName;
        else Console.WriteLine("Country code not found!!");

        return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(Dictionary<int, string> existingDictionary, int countryCode)
    {
        if (CheckCodeExists(existingDictionary, countryCode)) existingDictionary.Remove(countryCode);
        else Console.WriteLine("Country code not found!!");

        return existingDictionary;
    }
    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        int max=0;
        string s="";
        foreach(var d in existingDictionary)
        {
            if(d.Value.Length > max)
            {
                max=d.Value.Length;
                s=d.Value;
            }
        }
        return s;
    }


}



class Program
{
    public static void Main(string[] args)
    {
        Dictionary<int,string> d1 = DialingCodes.GetEmptyDictionary();


        Console.WriteLine("Task 1");
        foreach(var d in d1)
        {
            Console.WriteLine(d.Key+": "+d.Value);
        }

        Console.WriteLine("\nTask 2");
        foreach(var d in DialingCodes.GetExistingDictionary())
        {
            Console.WriteLine(d.Key+": "+d.Value);
        }

        Console.WriteLine("\nTask 3");
        d1 = DialingCodes.AddCountryToEmptyDictionary(81,"Japan");
        foreach(var d in d1)
        {
            Console.WriteLine($"countryCode = {d.Key},countryName = {d.Value}");
        }

        Console.WriteLine("\nTask 4");
        d1=DialingCodes.AddCountryToExistingDictionary(d1,44,"UK");
        foreach(var d in d1)
        {
            Console.WriteLine($"countryCode = {d.Key},countryName = {d.Value}");
        }

        Console.WriteLine("\nTask 5");
        Console.WriteLine(DialingCodes.GetCountryNameFromDictionary(d1,44));

        Console.WriteLine("\nTask 6");
        Console.WriteLine(DialingCodes.CheckCodeExists(d1,1));
        
        Console.WriteLine("\nTask 7");
        d1=DialingCodes.UpdateDictionary(d1,81,"Japanese");
        foreach(var d in d1)
        {
            Console.WriteLine($"countryCode = {d.Key},countryName = {d.Value}");
        }

        Console.WriteLine("\nTask 8");
        d1=DialingCodes.RemoveCountryFromDictionary(d1,81);
        foreach(var d in d1)
        {
            Console.WriteLine($"countryCode = {d.Key},countryName = {d.Value}");
        }

        Console.WriteLine("\nTask 9");
        Console.WriteLine(DialingCodes.FindLongestCountryName(d1));
    }
}