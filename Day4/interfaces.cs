using System;
interface A
{
    public void Display();
}
interface B
{
    public void Show();
}
public class C : A, B
{
    public void Display()
    {
        Console.WriteLine("In Display");
    }
    public void Show()
    {
        Console.WriteLine("In Show");
    }
}