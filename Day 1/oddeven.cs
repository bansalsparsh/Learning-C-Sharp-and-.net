using System;
class OddEven
{
    public static void OE()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt16(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is Even");
        }
        else
        {
            Console.WriteLine($"{num} is odd");
        }
    }
}