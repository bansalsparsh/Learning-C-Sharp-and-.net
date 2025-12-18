using System;
class Sum
{
    public static void Digit()
    {
        int n=134, sum=0;
        while (n > 0)
        {
            sum+=(n%10);
            n/=10;
        }
        Console.WriteLine(sum);
    }
}