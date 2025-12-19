using System;
class ForF
{
    public static void F()
    {
        // for(int i = 20; i <= 30; i++)
        // {
        //     Console.WriteLine($"\nTable of {i}");
        //     for(int j = 1; j <= 10; j++)
        //     {
        //         Console.WriteLine($"{i} X {j} = {i*j}");
        //     }
        // }

        Console.WriteLine("Game Begins: ");
        for(int i = 1; i < 10; i++)
        {
            if(i==4)
            {
                Console.WriteLine($"Enemy {i} is invisible. Skipping Enemy {i}");
                continue;
            }
            Console.WriteLine($"Player killed Enemy {i}");
        }
        Console.WriteLine("Game Over");
    }
}