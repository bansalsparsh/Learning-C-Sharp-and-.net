using System;
namespace LibrarySystem.Items;
abstract class LibraryItem
{
    public required string Title{get;set;}
    public required string Author{get;set;}
    public int ItemId{get;set;}
    public abstract void ItemDetails();
    public abstract double LateFee();
}
partial class Book : LibraryItem
{
    
    public override void ItemDetails()
    {
        Console.WriteLine("Item Type: Book");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"LateFee: {LateFee()}\n");
    }
    public override double LateFee()
    {
        return 3*1.0;
    }
    
}
class Magazine : LibraryItem
{
    public override void ItemDetails(){
        Console.WriteLine("Item Type: Magazine");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"LateFee: {LateFee()}\n");
    }
    public override double LateFee()
    {
        return 3*0.5;
    }   
}