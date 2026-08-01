using System;
using System.Collections.Generic;
using System.Text;
class Solution
{
    public static void SwapUsingRef(ref int a, ref int b){
        int temp = a;
        a=b;
        b=temp;
    }
    public static void SwapUsingOut(int a, int b, out int x, out int y){
        x=b;
        y=a;
    }
    public static void Main(string[] args){
        int a=10,b=5;
        SwapUsingRef(ref a, ref b);
        Console.WriteLine($"Swap using Ref: a={a} and b={b}");
        int og_x=10,og_y=5;
        SwapUsingOut(og_x, og_y, out int x, out int y);
        Console.WriteLine($"Swap using Out: x={x} and y={y}");
        
    }
}
