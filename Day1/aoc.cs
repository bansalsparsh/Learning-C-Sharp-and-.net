using System;
class Area
{
    public static void Aoc()
    {
        //prompting user for radius
        Console.Write("Enter radius of circle: ");

        // reading input from user using ReadLine() into String and then converting it to integer
        int a = Convert.ToInt16(Console.ReadLine());


        float area_circle = 3.14f * a * a;
        Console.WriteLine($"Area of Circle = {area_circle}");
    }
}