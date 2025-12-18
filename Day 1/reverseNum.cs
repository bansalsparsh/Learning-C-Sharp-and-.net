using System;
class Rev
{
    public static void Reverse()
    {
        int n=134,res=0;
        while (n > 0)
        {
            res = res*10+(n%10);
            n/=10;
        }
        Console.WriteLine(res);
    }
}