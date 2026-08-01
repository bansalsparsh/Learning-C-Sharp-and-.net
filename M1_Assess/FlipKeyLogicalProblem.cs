using System;
using System.Collections.Generic;
using System.Text;
class Solution
{
    public static string CleanseAndInvert(string input)
    {
        if(input.Length < 6) return "Invalid Input";

        input=input.ToLower();
        List<char> list = new List<char>();
        for(int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (!char.IsLetter(c)) return "Invalid Input";
            if (((int)c) % 2 != 0) list.Add(c);
        }
        list.Reverse();
        for(int i = 0; i<list.Count; i += 2)
        { 
            list[i]=Char.ToUpper(list[i]);
        }
        return string.Concat(list);
    }
    public static void Main(string[] args){
        string s = Console.ReadLine();
        string ans = CleanseAndInvert(s);
        Console.WriteLine(ans.Trim());
    }
}
