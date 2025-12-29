using System;
using System.Text;
class FlipLogic
{
    public string CleanseAndInvert(string input)
    {
        if(input.Length < 6) return "";

        input=input.ToLower();
        char[] arr = new char[input.Length];
        int x=0;
        for(int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (!char.IsLetter(c)) return "";
            int ascii = c;
            if (ascii % 2 != 0) arr[x++]=c;
        }
        Array.Reverse(arr);
        for(int i = 0; i < arr.Length; i += 2)
        { 
            arr[i]=Char.ToUpper(arr[i]);
        }
        return new String(arr);
    }
}