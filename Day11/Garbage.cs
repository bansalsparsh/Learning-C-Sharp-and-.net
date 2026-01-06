using System;
class MyClass
{
    ~MyClass()
    {
        Console.WriteLine("Fializers called, object collected.");
    }
}