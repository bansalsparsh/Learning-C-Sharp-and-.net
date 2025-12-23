using System;
class X
{
    // virtual tells that the method can be overridden
    public virtual void Xx()
    {
        Console.WriteLine("In x");
    }
}
class Y:X
{
    // override tells that the method is overidden
    public override void Xx()
    {
        base.Xx();
        Console.WriteLine("In Y");
    }
}