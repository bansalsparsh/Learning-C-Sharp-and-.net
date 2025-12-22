using System;
class Program
{
    static Func<int,int,int> Add = (a,b)=>a+b;
    static Func<int,int,int> Sub = (a,b)=>a-b;
    static void Main()
    {
        Console.WriteLine(Add(4,3));
        Console.WriteLine(Sub(4,3));
    }
}