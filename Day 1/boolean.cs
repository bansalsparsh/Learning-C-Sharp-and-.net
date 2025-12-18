using System;
class License
{
    public static void Check()
    {
        int age = 20;
        bool hasLicense = true;
        if(age>=18 && hasLicense)
        {
            Console.WriteLine("You are allowed to drive");
        }
        else
        {
            Console.WriteLine("You are not allowed to drive");
        }
    }
}