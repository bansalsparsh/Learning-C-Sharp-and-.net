using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static List<int> Mul(int n, int upto){
        List<int> list = new List<int>();
        for(int i=1;i<=upto;i++){
            list.Add(n*i);
        }
        return list;
    }
    public static void Main(string[] args)
    {
        List<int> ans = Mul(3,5);
        foreach(int num in ans){
            Console.Write(num+" ");
        }
    }
}
