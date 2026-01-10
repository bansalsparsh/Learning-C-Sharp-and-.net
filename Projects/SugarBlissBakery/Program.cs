using System;
class Chocolate
{
    public string Flavour{get;set;}
    public int Quantity{get;set;}
    public int PricePerUnit{get;set;}
    public double TotalPrice{get;set;}
    public double DiscountedPrice{get;set;}

    public bool ValidateChocolateFlavour()
    {
        if (Flavour.Equals("Dark") || Flavour.Equals("Milk") || Flavour.Equals("White"))
        {
            return true;
        }
        return false;
    }
}
class Program
{
    public static Chocolate CalculateDiscountedPrice(Chocolate ch)
    {
        ch.TotalPrice = ch.Quantity * ch.PricePerUnit;
        int DiscountPercentage = 0;
        if (ch.Flavour.Equals("Dark"))
        {
            DiscountPercentage=18;
        }else if (ch.Flavour.Equals("Milk"))
        {
            DiscountPercentage=12;
        }
        else
        {
            DiscountPercentage=6;
        }
        ch.DiscountedPrice = ch.TotalPrice - (ch.TotalPrice * DiscountPercentage / 100);
        return ch;

    }
    public static void Main(string[] args)
    {
        Chocolate ch = new Chocolate();
        Console.Write("Flavour: ");
        ch.Flavour = Console.ReadLine();
        Console.Write("Quantity: ");
        ch.Quantity = int.Parse(Console.ReadLine());
        Console.Write("Price per unit: ");
        ch.PricePerUnit = int.Parse(Console.ReadLine());
        if (ch.ValidateChocolateFlavour())
        {
            CalculateDiscountedPrice(ch);
            Console.WriteLine(ch.TotalPrice);
        }
        else
        {
            Console.WriteLine("Invalid Flavour!!");
        }

    }
}