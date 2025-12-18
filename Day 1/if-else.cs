using System;
class Condition
{
    public static void Cond()
    {
        // int age = 19;
        // if (age >= 18)
        // {
        //     Console.WriteLine("You are Eligible!!");
        // }
        // else
        // {
        //     Console.WriteLine("You are not Eligible!!");
        // }


        Console.Write("Enter score: ");
        int score=Convert.ToInt16(Console.ReadLine());
        if (score > 90)
        {
            Console.WriteLine('O');
        }else if (score >= 80)
        {
            Console.WriteLine("A+");
        }else if (score >= 70)
        {
            Console.WriteLine("A");
        }else if (score >= 60)
        {
            Console.WriteLine("B+");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}