using System;
class LargestOfThree
{
    public static int Largest(int a, int b, int c)
    {
        return Math.Max(a,Math.Max(b,c));
    }
}