using System;
using System.Text.RegularExpressions;

class Reg
{
    public static void Rege()
    {
        
        // string s1 = "abc123";
        // string s1 = "123123";
        // string s1 = "absabs";
        // string s1 = "123_123";

        // bool res = Regex.IsMatch(s1,@"\d"); // (\d) checks if string contains digit in it or not
        // Console.WriteLine(res);


        // string s1 = "Amount:5000";
        // string s1 = "5000Amount";
        // Match m = Regex.Match(s1,@"\d*"); // * check whether there is zero or more occurences like for digit
        // Console.WriteLine(m.Value);




        // string s1 = "Amount:5000";
        // string s1 = "5000Amount";
        // string s1 = "10a20b30c";
        // string s1 = "absc";

        // MatchCollection m = Regex.Matches(s1,@"\D"); // \D checks for non digits and Matches return all occurences of that regex
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }





        // string s1 = "10*\ta20B@_ !abs";
        // MatchCollection m = Regex.Matches(s1,@"\w"); // \w allows digit or char or _ only, no special symbols with spaces
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }


        // string s1 = "10*\ta20B@_ !abs";
        // MatchCollection m = Regex.Matches(s1,@"\W"); // \W is opposite of \w means it allows all special symbols incluing space but excluding _
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }





        // string s1 = "10*\ta20\nB@_ !abs";
        // MatchCollection m = Regex.Matches(s1,@"\s"); // \s returns whitespaces or tabs or new line
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }


        // string s1 = "10*\ta20\nB@_ !abs";
        // MatchCollection m = Regex.Matches(s1,@"\S"); // \S returns everything except whitespaces or tabs or new line
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }






        // string s1 = "10*\ta20\nB@_ !absfile.txt";
        // string s1 = "10*\ta20\nB@_ !.abs";
        // MatchCollection m = Regex.Matches(s1,@"\.txt"); // \S returns everything except whitespaces or tabs or new line
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }





        // string s1 = "10*\ta20\nB@_ !ab\sc:\abc\\file.txt";
        // MatchCollection m = Regex.Matches(s1,@"\\"); // \\ checks if 2 back slash present return single back slash
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }





        // string s1 = "10*\ta20\nB??@_ !ab?sc:\abc\\fi???le.txt";
        // MatchCollection m = Regex.Matches(s1,@"\?"); // \\ return all question marks
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x);
        // }





        // string s1 = "Hello10*\ta20\nB??@_ !ab?sc:\abc\\fi???le.txtHello";
        // string s1 = "Hello10*\ta20\nB??@_ !ab?sc:\abc\\fi???le.txtH";
        // string s1 = "Hello";
        // Match m = Regex.Match(s1,@"Hello$"); // $ indicates end of string
        // Console.WriteLine(m);
        // Match m = Regex.Match(s1,@"^Hello"); // ^ indicates starting with particular string
        // Console.WriteLine(m);
        // Match m = Regex.Match(s1,@"^Hello$"); // 
        // Console.WriteLine(m);






        // string s1 = "Date: 2025-12-29";
        // string s1 = "Date: 2025/12/29";
        // Match m = Regex.Match(s1, @"(\d{4})-(\d{2})-(\d{2})"); // \d{4} means 4 digit continuos 
        // Console.WriteLine(m);






        // string s1 = "Amount=5000";
        // string pattern = @"Amount=(?<value>\d+)"; //?<variable> creates a group named variable and stores value in that group
        // Match m = Regex.Match(s1,pattern);
        // Console.WriteLine(m);


        // string s1 = "23-02-1992";
        // string s1 = "1992-02-23, 2005-02-09";
        // string pattern = @"(?<year>\d{4})-(?<month>\d{2})-(?<date>\d{2})";
        // MatchCollection m = Regex.Matches(s1, pattern);
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x.Groups["year"].Value+"/"+x.Groups["month"].Value+"/"+x.Groups["date"].Value);
        // }






        // string s1 = "1992-02-23, 2005-02-09";
        // string pattern = @"(\d{4})-(\d{2})-(\d{2})";
        // Match m = Regex.Match(s1, pattern);
        // Console.WriteLine(m.Groups[0].Value); // 0 prints whole date
        // Console.WriteLine(m.Groups[1].Value); // 1 prints year
        // Console.WriteLine(m.Groups[2].Value); // 2 prints months
        // Console.WriteLine(m.Groups[3].Value); // 3 prints day number

        // MatchCollection m = Regex.Matches(s1, pattern);
        // foreach(Match x in m)
        // {
        //     Console.WriteLine(x.Groups[0].Value);
        // }






        // string s1 = "apple";
        // string pattern1 = @"a..";  // . allows any thing in its place even space except \n and acts as quantifier
        // string pattern2 = @"a...e";
        // Match m1 = Regex.Match(s1,pattern1);
        // Console.WriteLine(m1);
        // Match m2 = Regex.Match(s1,pattern2);
        // Console.WriteLine(m2);






        List<string> emails = new List<string>
        {
            "john.doe@gmail.com",
            "alice_123@yahoo.in",
            "mark.smith@company.com",
            "support-abc@banking.co.in",
            "user.nametag@domain.org",
            "john.doe@gmail",
            "alice@@yahoo.com",
            "mark.smith@.com",
            "support@banking..com",
            "user name@gmail.com",
            "@domain.com",
            "admin@domain",
            "info@domain,com",
            "finance#dept@corp.com",
            "plainaddress"
        };
        
        // \. checks for actual dot in string and acts as literal
        // string pattern = @"^[\w.-]+@[\w-]+\.\w{2,}$";
        // foreach(string x in emails)
        // {
        //     bool res = Regex.IsMatch(x,pattern);
        //     if (res)
        //     {
        //         Console.WriteLine("Valid"+" : "+x);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid"+" : "+x);
        //     }
        // }








    }
}
