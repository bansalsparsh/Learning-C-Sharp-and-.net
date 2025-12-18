using System;
class BinarySum
{
    public static void Bin()
    {
        int a=1001, b=1101;
        int numa=0,numb=0,i=0;
        while (a > 0)
        {
            if (a % 10 == 1)
            {
                numa+=(int)Math.Pow(2,i);
            }
            i++;
            a/=10;
        }
        i=0;
        while (b > 0)
        {
            if (b % 10 == 1)
            {
                numb+=(int)Math.Pow(2,i);
            }
            i++;
            b/=10;
        }
    }
}