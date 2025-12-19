using System;
class Feet
{
    public static void ConvertToFeet(int cm)
    {
        float feet = cm/30.48f;
        Console.WriteLine($"Feet = {feet}");
    }
}